using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LinhadeChegada : MonoBehaviour{
    [SerializeField] float Delay=2f;
    [SerializeField] ParticleSystem particulasDaVitoria;
    AudioSource somDeVitoria;
    bool vitorioso = false;

    void Start() {
        somDeVitoria = GetComponent<AudioSource>();    
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag=="Player" && !vitorioso){
                vitorioso=true;
                particulasDaVitoria.Play();
                somDeVitoria.Play();
                Invoke("Reiniciar", Delay);
        }
        
   }

    void Reiniciar(){
        SceneManager.LoadScene(0);
    }

}
