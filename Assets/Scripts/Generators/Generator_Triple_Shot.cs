using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Triple_Shot : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] GameObject powerTripleShot;
    private float minX = -8f;
    private float maxX = 8f;

    void Start()
    {
        StartCoroutine(generarTripleShot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        IEnumerator generarTripleShot(){


    float esperas = Random.Range(10,12f);    
    yield return new WaitForSeconds(esperas);
    GameObject speed = Instantiate(powerTripleShot, transform.position, Quaternion.identity); 
    speed.transform.position += Vector3.left * Random.Range(maxX, minX);
    StartCoroutine(generarTripleShot());
    
}
}
