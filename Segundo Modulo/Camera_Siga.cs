using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSiga : MonoBehaviour
{
    /*
    O propósito desse código é fazer com que a camera siga o personagem.
        Começamos com o SerializeField que fará com que a interface gráfica
        da unity se comunique com o script C#. Passamos o parametro GameOb-
        ject que indica que estaremos passando uma sprite como dado e a cha-
        mamos de sigaIstoAqui. 
    */
    [SerializeField] GameObject sigaIstoAqui;

    /*
    Como queremos que a camera sempre siga o personagem, nada melhor do
    que fazer isso a cada frame, por isso colocamos no update. o método
    transform.position acessa os valores relativos a posição da camera,
    sigaIstoAqui.transform.position acessa os valores da posição da spri-
    te informada, como transform.position é na verdade um vetor de 3 po-
    sições, fazemos uma soma com (0,0,-10). Isso evita que a camera sobre-
    ponha o resto do mapa e dificulte a visualização das outras sprites.
    */
    void LateUpdate()
    {
        transform.position = sigaIstoAqui.transform.position + new Vector3(0,0,-10);
    }
}
