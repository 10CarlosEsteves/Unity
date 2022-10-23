using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAnima : MonoBehaviour
{
    [SerializeField] float volanteVel=150f;
    [SerializeField] float yVel=10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        /*
        A depender do computador do usuário, a sprite pode ir
        rapida demais ou devagar demais, tudo depende do FPS.
        Para tornar a velocidade padrão para todos os computa-
        dores, usamos o Time.deltaTime transforma os frames por
        segundo em variáveis que podemos usar, assim 100FPS sig-
        nifica que a cada 1s temos 100 frames, logo temos 1 frame
        a cada 0,01 segundos, este 0,01 segundos é o valor retor-
        nado pelo Time.deltaTime . Usando esse valor, podemos tor-
        nar constante a velocidade da sprite em todos os tipos de 
        PC. Por isso multipliquei pela variável novovlanteVel e 
        novoYVel, também usei o volanteVel e yVel para não tornar
        o movimento da sprite pesada, pense neles como 150 e 10 
        respectivamente.
        */
        
        float novovolanteVel = Input.GetAxis("Horizontal") * volanteVel * Time.deltaTime;
        float novoYVel = Input.GetAxis("Vertical")* yVel * Time.deltaTime;

        transform.Rotate(0,0,-novovolanteVel);
        transform.Translate(0,novoYVel,0);
    }
}
