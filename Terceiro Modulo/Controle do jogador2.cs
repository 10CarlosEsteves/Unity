using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Jogador : MonoBehaviour{

        /*
        Em relação a antiga versão, acrescentamos novas
        funcionalidades para melhorar a mecanica e expe-
        riencia de jogo. Adcionamos a funcionalidade de 
        acelerar e freiar durante o jogo. Para isso cri-
        amos as variáveis velocidadeBoost,velocidadeNor-
        mal, efeitoDeSuperficie.
        */
        [SerializeField] float tantoDeTorque=8f;
        [SerializeField] float salto =400f;

        [SerializeField] float velocidadeBoost= 30f;
        [SerializeField] float velocidadeNormal = 20f;
        [SerializeField] float freios = 10f;

        SurfaceEffector2D efeitoDeSuperficie;  
        
        public bool  chao; 

        Rigidbody2D CorpoRigido;
        
    // Start is called before the first frame update
    void Start(){
    
        /*
        Usando FindObjectOfType para encontrar alguma sprite
        que contenha SurfaceEffector, delegamos a função de
        encontrar a sprite para a unity, como só temos uma
        sprite com essa função, não teremos problemas
        */
        
        efeitoDeSuperficie = FindObjectOfType<SurfaceEffector2D>();

        CorpoRigido = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    
    //Criamos métodos(funções) para guardar nossas mecanicas
    //e deixar menos bagunçado.
    
    void Update(){

        Movimentar();
        MudarVelocidade();
    }

    void Movimentar(){
        //Rodar para Esquerda
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            CorpoRigido.AddTorque(tantoDeTorque);
        }

        //Rodar para direita
        else if (Input.GetKey(KeyCode.RightArrow)  || Input.GetKey(KeyCode.D)){
            CorpoRigido.AddTorque(-tantoDeTorque);
        }

        //Saltar
        else if(Input.GetKeyDown(KeyCode.Space) && chao){
            CorpoRigido.AddForce(Vector2.up*salto);
            chao = false;
        }
    }



    /*
    Aqui, fazemos uso do componente SurfaceEffector2D salvos
    na variável efeitoDeSuperficie. Com isso conseguimos cri-
    ar a mecanica de acelerar e freiar.
    */
    
    void MudarVelocidade(){

        //Se apertar a seta pra cima,
        //aumentar a velocidade
        if( Input.GetKey(KeyCode.UpArrow) ){
            efeitoDeSuperficie.speed =velocidadeBoost; 
        }

        //Se apertar a seta pra baixo,
        //Diminua a velocidade
        else if(Input.GetKey(KeyCode.DownArrow)){
            efeitoDeSuperficie.speed = freios;
        }

        //Caso nenhum dos dois forem apertados,
        //Apenas volte ao normals
        else{
            efeitoDeSuperficie.speed = velocidadeNormal;
        }

    }


}
