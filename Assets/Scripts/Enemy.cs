using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    public  Transform spawn;

    

  private float destrucciones = 7;
    private bool derecha;
  
    


    void Start()
    {
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
       

       if(transform.position.x <= -8){

        derecha = true;

       }

       else if(transform.position.x >= 8){

        derecha = false;
       }

        if(derecha == true){

            transform.position += Vector3.right * speed * Time.deltaTime;

        }

       else if (derecha == false){

        
         transform.position += Vector3.left * speed * Time.deltaTime;
       }



    }


    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "Laser"){

        Debug.Log("hola colisione con el laser");

        destrucciones -= 1;

      }
    }

   



  
}
