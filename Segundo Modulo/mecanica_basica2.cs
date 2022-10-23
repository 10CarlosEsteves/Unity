using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAnima : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        /*
        A unity possui mecanismos prontos para evitar que
        o programador reinvente a roda. Um desses mecanismos
        permite coletar inputs do usuário para fazer um sprite
        se mover. Nesse programa, criamos uma variável chamada
        de novovolanteVel e usamos Input.GetAxis. Toda vez que
        o frame é atualizado a variável guarda o valor do input
        se o jogador não apertar um butão, Input.GetAxis retorna
        0 e o sprite não se move, se algo for apertado então ele
        retorna -1 ou 1 a depender da direção é claro. Essa lógica 
        também vale para o novoYVel. colocamos  -novovolanteVel no 
        Rotate por que elevirava mas virava na direção contrária a 
        desejada
        */
        
        float novovolanteVel=Input.GetAxis("Horizontal");
        float novoYVel=Input.GetAxis("Vertical")*0.5f;
        
        transform.Rotate(0,0,-novovolanteVel);
        transform.Translate(0,novoYVel,0);
    }
}
