using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0.05f;
    
    void Start()
    {
        
    }

    
    void Update()
    {

        
        //new Vector2(speed * Time.deltaTime,0);
        
      transform.Rotate(speed * Time.deltaTime, speed, 0); // movimineto de la tierra
      //transform.rotation = Quaternion.Slerp(transform.rotation,   Time.deltaTime * speed);


        
        
    }
}
