using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Laser_Enemy : MonoBehaviour
{
    public GameObject LaserEnemy;
    void Start()
    {

        //InvokeRepeating(nameof(spawn),range,range2);
        StartCoroutine(dispararEnemigo());
        
    }

    IEnumerator dispararEnemigo(){


    float esperas = Random.Range(3,7.5f);    
    yield return new WaitForSeconds(esperas);
    GameObject laserEnemy = Instantiate(LaserEnemy, transform.position, Quaternion.identity); 
    StartCoroutine(dispararEnemigo());
    
}

}
