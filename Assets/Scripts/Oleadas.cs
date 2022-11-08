using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//


[System.Serializable]


public class wave{
    public string waveNames;
    
    public float intervaloTiempo;
    public GameObject enemys;
    public GameObject spawnerEnemys;
    public int cantidadEnemigos;
    private bool boss;
}
public class Oleadas : MonoBehaviour
{
    public int contador;
    private float minY = -2f;
    private float maxY = 3.5f;

    public  wave[] olas;
    public Laser cuentas;


    public int muertes;
    public int muertos;


    private void Awake() {
        
        InvokeRepeating(nameof(GeneratorEnemy),olas[contador].intervaloTiempo, olas[contador].intervaloTiempo);
    }
       private void Start() {
        contador = 0;  
    }
    private void Update() {
         
        muertes = cuentas.enemysDeaths;

        Debug.Log("muertes"+muertes);       
    }


    private void GeneratorEnemy(){
        
         if(olas[contador].cantidadEnemigos > 0){

            StartCoroutine(spawnEnemys());
 
            }

        else if(olas[contador].cantidadEnemigos <= 0 && muertes <= 0){
            Debug.Log("paso de ola: "+olas[contador] +1);
            esperar();
            cuentas.enemysDeaths =  olas[contador].cantidadEnemigos;
            contador += 1; 
            
        }
             
    }



    IEnumerator esperar(){

        Debug.Log("Nueva ola en 5 segundos");
        yield return new WaitForSeconds(5f);
    }


    IEnumerator spawnEnemys(){

        yield return new WaitForSeconds(olas[contador].intervaloTiempo);
        GameObject enemigo = Instantiate(olas[contador].enemys,transform.position, Quaternion.identity);
            enemigo.transform.position += Vector3.up * Random.Range(minY, maxY);
            olas[contador].cantidadEnemigos -= 1;

    }

     
    


    


}
