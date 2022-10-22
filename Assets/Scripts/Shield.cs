using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * speed* Time.deltaTime;
        Destroy(gameObject, 3f);
        
    }
}
