using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Criação da classe carro
public class CarroAnima : MonoBehaviour
{
    /*
      Adição de váriaveis tipo float
      Adição de atribuição as variáveis entre []
      A atribuição SerializeField nos permite
      manipular os valores das variáveis pelo
      inspector do unity em tempo real
    */
    [SerializeField] float volanteVel=0.5f;
    [SerializeField] float yVel=0.05f;


    // Start is called before the first frame update
    void Start()
    {
       //A função Debug.Log imprime mensagens no console
       //Isso será util em debugs futuros.
       Debug.Log(volanteVel);
       Debug.Log(yVel);
    }

    // Update is called once per frame
    void Update()
    {
        //Os metodos transform.Rotate permite rotacionar
        //o objeto em x,y,z. Como usamos apenas o z ele
        //vira pra esquerda ou para direita ao redor de seu
        //eixo
        transform.Rotate(0,0,volanteVel);
        
        //Os metodos transform.Translate permite movimentar
        //o sprite ao longo do x e do y e do z. Ele se move
        //em direção em que suas setas apontam
        
        transform.Translate(0,yVel,0);
    }
}
