using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{

    public float speed = 6f;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, 4f);
        
    }


    public void destroy(){
        

        print("funcion destroy nueva");
        Destroy(gameObject);
    }


   

}


