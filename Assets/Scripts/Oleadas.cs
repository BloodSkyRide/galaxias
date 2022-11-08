using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//


[System.Serializable]


public class wave{ // ABSTRACCION DE UNA OLA
    public float intervaloTiempo; // intervalo de tiempo de creacion de enemigos
    public GameObject enemys; //objeto de los diferentes posibles enemigos
    public int cantidadEnemigos; // cantidad de enemigos a crear por oleada
}
public class Oleadas : MonoBehaviour
{
    public int contador; // contador de la ola en la que esta
    private float minY = -2f;
    private float maxY = 3.5f;

    public  wave[] olas; // de la clase WAVE se hace una lista para las diferentes oleadas
    public Laser cuentas; // Referencia del objeto Laser del jugador
    public int muertes;



    private void Awake() {
        
        InvokeRepeating(nameof(GeneratorEnemy),olas[contador].intervaloTiempo, olas[contador].intervaloTiempo); //llamo al metodo generator enemy con los intervalos de tiempo de cada posicion de la lista de oleadas o WAVES
    }
       private void Start() {
        contador = 0;  // arranco el array list en la posicion 0, lo que quiere decir que es la primera oleada
    }
    private void Update() {
         
        muertes = cuentas.enemysDeaths; // asigno la variable en tiempo real de las bajas que tiene el jugador 

        Debug.Log("muertes"+muertes);  
         if(Input.GetKeyDown(KeyCode.K)){

            contador = 2;
         }     
    }


    private void GeneratorEnemy(){
        
         if(olas[contador].cantidadEnemigos >= 0){ // evaluo que cree los enemigos siempre y cuando la cantidad de enemigos preestablecida en la lista de ese indice sea mayor o igual a cero

            StartCoroutine(spawnEnemys());
 
            }

        else if(olas[contador].cantidadEnemigos <= 0 && muertes <= 0){ // evaluo que para sumar el indice de la lista de oleadas el jugador alla eliminado a los enemigos y que la cantidad de enemigos sea menor o igual a 0
            Debug.Log("paso de ola: "+olas[contador] +1);
            StartCoroutine(esperar());
            cuentas.enemysDeaths =  olas[contador].cantidadEnemigos;
            contador += 1; 
            
        }
             
    }



    IEnumerator esperar(){

        Debug.Log("Nueva ola en 5 segundos");
        yield return new WaitForSeconds(5f);
    }


    IEnumerator spawnEnemys(){

        yield return new WaitForSeconds(olas[contador].intervaloTiempo); // tiempo de espera segun la lista y el indice en que se encuentre
        GameObject enemigo = Instantiate(olas[contador].enemys,transform.position, Quaternion.identity); // instancia el enemigo segun el indice en el que se encuentre
            enemigo.transform.position += Vector3.up * Random.Range(minY, maxY);
            olas[contador].cantidadEnemigos -= 1;// le reto 1 cada que se instancia un enemigo

    }

     
    


    


}
