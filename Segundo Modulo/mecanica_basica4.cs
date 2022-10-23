using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour{

    /*
    Este método abaixo é como funciona a física
    básica da unity, onCollisionEnter2D é um mé-
    todo que analisa se meu sprite colidiu com 
    algo, se ele colidir, a mensagem no escopo
    será printada no console.
    */
    
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Voce colidiu com objeto");    
    }
    
    /*
    Este método abaixo é como funciona a física
    básica da unity, onTriggerEnter2D é um mé-
    todo que analisa se meu sprite interagiu  
    com outra sprite no jogo. Basicamente a in-
    teração é do tipo trigger, ou seja, aciona
    algo sem necessáriamente haver física de co-
    lisão.
    */
    
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Voce interagiu com gatilho");
        
    }
    
}
