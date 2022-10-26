using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAnimacao : MonoBehaviour
{

    [SerializeField] float Volante = 120f;
    [SerializeField] float Acelerador = 20f;
    [SerializeField] float Lentidao = 10f;
    [SerializeField] float impulso = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        Acelerador = Lentidao;
    }

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
