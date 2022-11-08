using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float  Speeds = 5f; //
    private bool derecha;
    private bool transportar;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x <= -7.6){  // evaluo el limite de la posicion del objeto, limite inferior en el eje X
        derecha = true;
       }

       else if(transform.position.x >= 7.6){// evaluo el limite de la posicion del objeto, limite superior en el eje X

        derecha = false;
        
       }

        if(derecha == true){
            
            transform.position += Vector3.right * Speeds * Time.deltaTime; // si la variable derecha es positiva es porque debe moverse a la derecha

        }

       else if (derecha == false){
         transform.position += Vector3.left * Speeds * Time.deltaTime; // si la variable derecha es falsa es porque debe moverse a la izquierda
       }

        
    }

}
