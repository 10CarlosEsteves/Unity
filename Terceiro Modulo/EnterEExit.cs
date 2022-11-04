using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterEExit : MonoBehaviour
{
   //Destinada a onCollisionEnter e OncollisionExit
   Controle_Jogador jogador;
   [SerializeField] ParticleSystem efeitoDeslizar;

   void Start(){
    jogador = GetComponent<Controle_Jogador>();
   }

    //Se houver contato com chão
   void OnCollisionEnter2D(Collision2D other) {
    jogador.chao=true;

    if(other.gameObject.tag=="Ground"){
        efeitoDeslizar.Play();
    }
    
   }

    //Se não houver contato com chão
   void OnCollisionExit2D(Collision2D other) {
    efeitoDeslizar.Stop();
    jogador.chao=false;
   }



}
