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

        if(transform.position.y <= -5){ // si el laser es menor o igual -5 en el eje y abajo se vuelve falso

            abajo = false;
        }

        else if (transform.position.y >= 5){ // si el laser es mayor o igual 5 en el eje y abajo se vuelve verdadero

            abajo = true;
        }

        if(abajo == true){ // evaluo si la variable abajo es verdadera muevo el objeto para abajo

            transform.position += Vector3.down * Time.deltaTime * velocidad; 
        }
        else{ // evaluo si la variable abajo es falsa muevo el objeto para arriba, pasados 4 segundos se destruye

            transform.position += Vector3.up * Time.deltaTime * velocidad;
            Destroy(gameObject, 4f);
        }

        
    }
}
