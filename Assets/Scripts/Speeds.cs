using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeds : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * Speed * Time.deltaTime;
        Destroy(gameObject, 3f);
    }   
}
