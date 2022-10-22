using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Speeds : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject powerSpeed;
    private float minX = -8f;
    private float maxX = 8f;

    void Start()
    {
        StartCoroutine(GenerarSpeeds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        IEnumerator GenerarSpeeds(){


    float esperas = Random.Range(8,10f);    
    yield return new WaitForSeconds(esperas);
    GameObject speed = Instantiate(powerSpeed, transform.position, Quaternion.identity); 
    speed.transform.position += Vector3.left * Random.Range(maxX, minX);
    StartCoroutine(GenerarSpeeds());
    
}
}
