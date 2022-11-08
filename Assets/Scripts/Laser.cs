using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Laser : MonoBehaviour
{
    private Rigidbody2D RG;
    [SerializeField] AudioSource destruction;

    public float Speed = 5f;

    public Oleadas oleadas;

    public int enemysDeaths ;
    
    private void Awake() {
         oleadas = FindObjectOfType<Oleadas>();
         enemysDeaths = oleadas.olas[oleadas.contador].cantidadEnemigos;
    }
    
    
    void Start()
    {

        
        RG = GetComponent<Rigidbody2D>(); // rigibody
        
        Debug.Log("numero enemigos iniciales: "+enemysDeaths );
        
    }

    // Update is called once per frame
    void Update()
    {
        //oleadas.muertes = enemysDeaths;
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        //RG.AddForce(Vector3.up * Speed, ForceMode2D.Impulse);
        //RG.velocity = new Vector2(0, Speed * Time.deltaTime);
        Destroy(gameObject, 3f); // se destruye el objeto 3 segundos despues de ser creado

       
        
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "collider"){             
            Destroy(other.gameObject);
            destruction.Play();
        } 

        else if(other.gameObject.tag == "enemy"){
                
                enemysDeaths -= 1;
                Destroy(other.gameObject);
                destruction.Play(); 
                Debug.Log("enemigos vivos: "+enemysDeaths);


            }
    }

    }





