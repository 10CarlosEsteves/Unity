using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour
{
    [SerializeField] Color32 pegoupacotecor = new Color32 (1,1,1,1);
    [SerializeField] Color32 naopegoupacotecor = new Color32 (1,1,1,1);
    
    bool temOPacote=false;

    SpriteRenderer spritecor;

    void Start() {
        spritecor = GetComponent<SpriteRenderer>();
    }
    
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Voce acertou algo");    
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag=="Entrega" && temOPacote==false){
            spritecor.color= pegoupacotecor;
            Debug.Log("Pacote coletado!");
            Destroy(other.gameObject,0f);
            temOPacote=true;
        }

        if(other.tag=="Cliente" && temOPacote==true){
            spritecor.color=naopegoupacotecor;
            Debug.Log("Pacote Entregue!");
            temOPacote=false;
        }



    }

}
