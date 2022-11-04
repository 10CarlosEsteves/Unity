using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Jogador : MonoBehaviour{
        [SerializeField] float tantoDeTorque=8f;
        [SerializeField] float salto =400f;

        [SerializeField] float velocidadeBoost= 30f;
        [SerializeField] float velocidadeNormal = 20f;
        [SerializeField] float freios = 10f;
        SurfaceEffector2D efeitoDeSuperficie;
        bool estaVivo = true;
          
        public bool  chao; 

        Rigidbody2D CorpoRigido;
        
    // Start is called before the first frame update
    void Start(){
        efeitoDeSuperficie = FindObjectOfType<SurfaceEffector2D>();

        CorpoRigido = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update(){

        if(estaVivo){
            Movimentar();
            MudarVelocidade();
        }
        
        else{
            BloquearControles();
        }
        
    }

    public void BloquearControles(){
        estaVivo = false;
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
