using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour{
        
        /*
        Este código se dedica a criar a mecanica de
        controle do jogador do terceiro módulo. Pri
        meiro de tudo, criamos um campo serializado
        para modificar o valor da variável na inter-
        face gráfica. Segundo criamos um objeto cha-
        mado CorpoRigido do tipo Rigidbody2D, o ob-
        jeto RigidBody é uma atribuição dada na inter-
        face gráfica da unity, isso também é comum com
        objetos transform que já é automaticamente de-
        clarada como Transform transform(definição cla-
        ssica de objeto).
        */
        
    [SerializeField] float tantoDeTorque=2f;
    Rigidbody2D CorpoRigido;

    // Start is called before the first frame update
    void Start(){
            
        /*
        Como CorpoRigido é do tipo Rigidbody, podemos
        presumir que ele altera diretamente as variaveis
        da interface gráfica. Aqui no Start, apenas dize-
        mos que ele iniciará o jogo com os valores padrõ-
        es
        */    
        CorpoRigido = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

        /*
        Aqui as coisas começam a ficar interessantes, aqui
        queremos que determinado input faça o jogador dar 
        uma cambalhota, voce deve estar se perguntando por
        que não usamos transform.rotate? transform.rotate
        fará com que as leis da física da unity sejam vio-
        lados, por isso é melhor trabalhar com Rigidbody2D
        que manterá as leis intactas. Input.Getkey nos dará
        mais controle sobre as varíaveis do teclado do usuá-
        rio, podemos personalizar as nossas próprias aqui,
        talvez isso se torne padrão daqui em diante. Coloca-
        mos que se for digitado -> ou D, o jogador dará uma
        cambalhota para esquerda.
        */    
            
        if(Input.GetKey(KeyCode.RightArrow)  || Input.GetKey(KeyCode.D)){
            CorpoRigido.AddTorque(-tantoDeTorque);
        }




    }
}
