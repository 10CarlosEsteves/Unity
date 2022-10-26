using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSiga : MonoBehaviour
{
    [SerializeField] GameObject sigaIstoAqui;

    void LateUpdate()
    {
        transform.position = sigaIstoAqui.transform.position + new Vector3(0,0,-10);
    }
}
