using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
   public float speed = 0.05f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(-speed * Time.deltaTime, speed, 0); // rotacion de sol
        
    }
}
