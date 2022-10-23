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
        float novovolanteVel = Input.GetAxis("Horizontal") * volanteVel * Time.deltaTime;
        float novoYVel = Input.GetAxis("Vertical")* yVel * Time.deltaTime;

        transform.Rotate(0,0,-novovolanteVel);
        transform.Translate(0,novoYVel,0);
    }
}
