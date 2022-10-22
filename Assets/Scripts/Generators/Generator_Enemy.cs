using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Enemy : MonoBehaviour
{

    private Transform posciones;
    public GameObject Enemys;
    private float minY = -2f;
    private float maxY = 3.5f;

    private float contEnemys;


    private void Awake() {
        InvokeRepeating(nameof(spawn),3f, 3f);
        
    }

     private void spawn(){


        if(contEnemys < 7){

            GameObject enemigo = Instantiate(Enemys, transform.position, Quaternion.identity); 
            enemigo.transform.position += Vector3.up * Random.Range(minY, maxY);
            contEnemys += 1;

            
            
        }

        else {

            CancelInvoke(nameof(spawn));


        }

    }
    
}
