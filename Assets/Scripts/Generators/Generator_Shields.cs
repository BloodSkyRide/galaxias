using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Shields : MonoBehaviour
{
    float minX = -8;
    float maxX = 8;
    [SerializeField] GameObject Shields;
    void Start()
    {
        StartCoroutine(generatorShields());
        
    }
    IEnumerator generatorShields(){

        float intervalo = Random.Range(12,15);
        yield return new WaitForSeconds(intervalo);
        GameObject shield = Instantiate(Shields, transform.position, Quaternion.identity);
        shield.transform.position += Vector3.left * Random.Range(maxX, minX);
        StartCoroutine(generatorShields());


    }
}
