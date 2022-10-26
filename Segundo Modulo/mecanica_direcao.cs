using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAnimacao : MonoBehaviour
{
    /*
        Vamos criar um impulso, a depender da sprite
        que o carro passa por cima, acionamos o boost
        e esse boost aumenta velocidade do carro. Se
        o nosso carro colidir com alguma coisa, ele 
        fica lento.
    */

    //Adição das variaveis Lentidao e impulso
    [SerializeField] float Volante = 120f;
    [SerializeField] float Acelerador = 20f;
    [SerializeField] float Lentidao = 10f;
    [SerializeField] float impulso = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Se houver colisão, nossa velocidade fica lenta
    void OnCollisionEnter2D(Collision2D other) {
        Acelerador = Lentidao;
    }

    //Se passarmos por algum gatilho e esse gatilho
    //tiver a tag "Boost", então ganhamos impulso
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Boost"){
            Acelerador= impulso;
        }
    }

    


    // Update is called once per frame
    void Update()
    {
        
        float novoVolante= Input.GetAxis("Horizontal")*Volante*Time.deltaTime;
        float novoAcelerador= Input.GetAxis("Vertical")*Acelerador*Time.deltaTime;

        transform.Rotate(0, 0, -novoVolante);
        transform.Translate(0, novoAcelerador, 0);
        
        
    }
}
