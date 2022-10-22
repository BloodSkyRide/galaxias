using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Triple_shot : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * speed * Time.deltaTime;
        Destroy(gameObject,3f);// pasados 3 segundos se destruye el objeto
        
    }

  
}
