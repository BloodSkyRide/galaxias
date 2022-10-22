using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    public float maxY = 4f;
    public float minY = -4f;
   private void OnEnable() {
        InvokeRepeating(nameof(spawn),2.5f, 2.5f);
        
    }

    private void spawn(){

        GameObject asteroid = Instantiate(prefab, transform.position, Quaternion.identity); // es la rotacion
        
        asteroid.transform.position += Vector3.up * Random.Range(minY, maxY);

    }

   /* private void OnDisable() {
        CancelInvoke(nameof(spawn));
    }*/




}
