using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float  Speeds = 5f;
    private bool derecha;
    private bool transportar;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
       if(transform.position.x <= -7.6){

        derecha = true;
        transporter();
       }

       else if(transform.position.x >= 7.6){

        derecha = false;
        transporter();
       }

        if(derecha == true){
            transporter();
            transform.position += Vector3.right * Speeds * Time.deltaTime;

        }

       else if (derecha == false){

        transporter();
         transform.position += Vector3.left * Speeds * Time.deltaTime;
       }

        
    }



    public void transporter(){

        float noSeSabe = Random.Range(0,1);

        if(noSeSabe == 1){

            float transborder = Random.Range(5,-5);
            float transborder2 = Random.Range(0,3);
            transform.position = new Vector3(transborder,transborder2,0);
            Debug.Log("Termine mi secuencia");


        } 
    }
}
