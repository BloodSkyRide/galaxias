using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Laser : MonoBehaviour
{
    public float velocidad = 5f;
    private bool abajo = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y <= -5){

            abajo = false;
        }

        else if (transform.position.y >= 5){

            abajo = true;
        }

        if(abajo == true){

            transform.position += Vector3.down * Time.deltaTime * velocidad;
        }
        else{

            transform.position += Vector3.up * Time.deltaTime * velocidad;
            Destroy(gameObject, 4f);
        }

        
    }
}
