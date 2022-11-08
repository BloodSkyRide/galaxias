using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Enemy : MonoBehaviour
{
    public GameObject Enemys;
    private float minY = -2f;
    private float maxY = 3.5f;

    public float contEnemys;
    public float cantidadEnemigos;

    private int ola;

    
    private void Awake() {
        InvokeRepeating(nameof(spawn),3f, 3f);
    }

     private void spawn(){


        if(contEnemys <= cantidadEnemigos){

            GameObject enemigo = Instantiate(Enemys, transform.position, Quaternion.identity); 
            enemigo.transform.position += Vector3.up * Random.Range(minY, maxY);
            contEnemys += 1;    
        }

        else {

            CancelInvoke(nameof(spawn));


        }
     }
}
