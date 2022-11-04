using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Detecte_Acidente : MonoBehaviour{

  
  [SerializeField] float Delay=2f;
  [SerializeField] SurfaceEffector2D superficie;
  [SerializeField] ParticleSystem sangramento;
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
        GetComponent<Controle_Jogador>().BloquearControles();
        GetComponent<AudioSource>().PlayOneShot(acidenteSFX);
        Invoke("Reiniciar", Delay);
    }
  }

  

  void Reiniciar(){
        SceneManager.LoadScene(0);
    }
    
}
