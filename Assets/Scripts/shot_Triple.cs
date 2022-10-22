using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class shot_Triple : MonoBehaviour
{
    private float speed = 5f;
    [SerializeField] AudioSource destruction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.up * speed * Time.deltaTime;
        Destroy(gameObject, 3f);


        
    }
      private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "collider"){             
            Destroy(other.gameObject);
           destruction.Play();
        } 

        else if(other.gameObject.tag == "enemy"){

                Destroy(other.gameObject);
               destruction.Play();


            }
    }
}
