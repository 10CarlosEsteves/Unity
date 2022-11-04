using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Detecte_Acidente : MonoBehaviour{

  /*
  Fizemos algumas modificações para dar ao jogo
  as seguintes funcionalidades: Som ao se aciden-
  tar e travar os controles do jogador, aqui apenas
  manipulamos as variáveis para bloquear os controles
  */
  
  [SerializeField] float Delay=2f;
  [SerializeField] SurfaceEffector2D superficie;
  [SerializeField] ParticleSystem sangramento;
  
  /*
  Se quiséssimos que várias musicas fossem to-
  cadas ao longo do jogo, então criaríamos vá-
  rios AudioClip como o abaixo e então podería-
  mos acessar cada um separadamente usando
  GetComponent<AudioSource>().PlayOneShot(acidenteSFX);
  */
  
  [SerializeField] AudioClip acidenteSFX;
  bool seAcidentou = false;

  void Start() {
    superficie.enabled = true;
  }
  
  //Gatilho da morte
  void OnTriggerEnter2D(Collider2D other){
    
    //Se eu bater no chão, o personagem sangra
    //o chão para de empurra-lo e o jogo reinicia.
    if (other.tag=="Ground" && !seAcidentou){
        seAcidentou = true;
        sangramento.Play();
        superficie.enabled=false;
        Debug.Log("Voce morreu!!!");
        //Acessso ao método de outro script
        GetComponent<Controle_Jogador>().BloquearControles();
        //Toque uma vez a música acidenteSFX
        GetComponent<AudioSource>().PlayOneShot(acidenteSFX);
        Invoke("Reiniciar", Delay);
    }
  }

  

  void Reiniciar(){
        SceneManager.LoadScene(0);
    }
    
}
