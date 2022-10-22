using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource sonido;
    [SerializeField] AudioSource destruccion;
    [SerializeField] AudioSource sonidoPower;

    //public Enemy enemigo;


    
    private SpriteRenderer spriteRenderer;
    
     Vector3 movimiento;

     private bool isTriple;

     public Transform  spawnBullet;
     public GameObject Laser;
     public GameObject Triple_Shot;
     public float maxY = 3.7f;
     public float miny = -3.7f;
     public float maxX = 8f;
     public float minX = -8F;
     float vidas = 3;
    public float Speed = 7f;


    

     float h;
    float v;
    private void Awake()
    {

        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void Start(){

        isTriple = false;
        
    }
    void Update()
    {
         v = Input.GetAxis("Vertical"); // deteccion de movimiento vertical
         h = Input.GetAxis("Horizontal"); // deteccion de movimiento horizontal
        movimiento.x = h;
        movimiento.y = v;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,minX,maxX), Mathf.Clamp(transform.position.y,miny,maxY),0); //limites del mapa
        transform.position += movimiento*Time.deltaTime*Speed; //movimiento

        // DISPARAR

        if(Input.GetKeyDown(KeyCode.Space)){ // presion de espacio para disparar


        if(!isTriple){

            disparar();

        }

        else{
            StartCoroutine(activeTripleShot());

        }
        
    }

}

private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "collider"){  // colision con los objetos que tengan un tag de Obstaculo como tubos y piso
            destruccion.Play();
            Destroy(other.gameObject);
            
           // asteroide.destroy();
            if(vidas == 1){
                StartCoroutine("destroyNave");
                
            }

            else{

                vidas = vidas - 1;
            }
            
            
        }

        else if (other.gameObject.tag == "Enemy_Laser"){ // colision con el objeto que tiene como tag puntos y llamo al metodo de incremento den puntaje

            destruccion.Play();
            Destroy(other.gameObject);
            
        }

         else if(other.gameObject.tag == "speed"){

                Destroy(other.gameObject);
                StartCoroutine(activeVelocity());
                sonidoPower.Play();


            } 


            else if(other.gameObject.tag == "tripleShot"){

                Destroy(other.gameObject);
                sonidoPower.Play();
                isTriple = true;


            }
            else if(other.gameObject.tag == "shield"){

                Destroy(other.gameObject);
                sonidoPower.Play();
                


            }

            
    }

    

    private void disparar(){

        
        GameObject bala = Instantiate(Laser, spawnBullet.position, Quaternion.identity); // instancia de prefab
        sonido.Play(); // sonido de disparo
    }


    public void gameOver(){


        
    }

    IEnumerator destroyNave(){

         yield return new WaitForSeconds(0.6f);
         Destroy(gameObject);

    }


    IEnumerator activeVelocity(){
        Speed = Speed *2;
        yield return new WaitForSeconds(5f);
        Speed = Speed /2;

    }

    IEnumerator activeTripleShot(){

        sonido.Play();
        GameObject tripleDisparo = Instantiate(Triple_Shot, spawnBullet.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        isTriple = false;

    }



    
}
