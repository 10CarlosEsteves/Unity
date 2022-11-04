using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterEExit : MonoBehaviour
{

   /*
   Destinada a onCollisionEnter e OncollisionExit
   Se um objeto estiver tocando em outr, então
   estamos diante de uma collisionEnter, quando
   ele não estiver tocando estamos diante de um
   collisionExit...Espero que tenha ficado claro.
   Aqui se dedica a criar mecanicas, bem como se
   o jogador estiver tocando o chão temos efeito
   de spray, caso não estiver tocando o chão, não
   temos o efeito, bem como criamos aqui o efeito
   de somente um salto.
   */
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
