using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
Descrição: Este script se destina a criar a detecção de acidentes
bem como suas devidas animações e modificações no jogo.
Aqui queremos 4 coisas básicas quando acontece um acidente.
A primeira é uma mensagem de morte no console do usuário, a
segundo é que tenha uma animação de sangramento, a terceira é
que o personagem pare de se mover e a quarta é um delay de tempo
antes de reiniciar o jogo
*/

public class Detecte_Acidente : MonoBehaviour{

  /*
  Começamos com o básico, criamos um float chamado Delay do tipo
  serializeField para modificarmos na interface gráfica. Depois
  criamos um GameObject, o GameObject nos permite manipular os com-
  ponentes de outras sprites, é um tipo de referencia. Também cria-
  mos uma outra referencia para a animação de sangramento que é do
  tipo ParticleSystem e permite arrastar a animação da interface 
  gráfica para o script assim como o GameObject. A principal dife-
  rença entre um GameObject e fazer um serializefield de componente
  é que o gameobject acessa todos os componentes e os manipulam, o
  serializefield de componente acessa especificamente um componente
  da sprite, podemos ainda acessar outros componentes mas é mais 
  fácil usar o GameObject nesse caso.
  */
  

  [SerializeField] float Delay=2f;
  public GameObject superficie;
  [SerializeField] ParticleSystem sangramento;
  

  void Start() {
    //Manipulando um componente da sprite e ativando sua movi-
    //mentação.
    superficie.GetComponent<SurfaceEffector2D>().enabled=true;
  }
  
  void OnTriggerEnter2D(Collider2D other){
    
    //Se eu bater no chão, o personagem sangra
    //o chão para de empurra-lo e o jogo reinicia.
    if (other.tag=="Ground"){
        Debug.Log("Voce morreu!!!");
        sangramento.Play();
        superficie.GetComponent<SurfaceEffector2D>().enabled=false;
        Invoke("Reiniciar", Delay);
    }
    
  }

  void Reiniciar(){
        SceneManager.LoadScene(0);
    }
    
}
