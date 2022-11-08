using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LaserEnemy;
    void Start()
    {

        //InvokeRepeating(nameof(spawn),range,range2);
       StartCoroutine(dispararEnemigo());
        
    }

    IEnumerator dispararEnemigo(){


    float esperas = Random.Range(1,2f);    
    yield return new WaitForSeconds(esperas);
    GameObject laserEnemy = Instantiate(LaserEnemy, transform.position, Quaternion.identity); 
    StartCoroutine(dispararEnemigo());
    
}
}
