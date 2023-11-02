using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coleccionables : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI contador;
    [SerializeField]
    GameObject pantallavictoria;
    [SerializeField]
    TextMeshProUGUI tiempo;
   

    public enemigo enemigoscript;

    //tiempo
    bool enpartida = true;
    float tiempoquehatardado = 0;
    

    private void Start()
    {
        pantallavictoria.SetActive(false);
        
    }

 private void Update()
    {
        transform.Rotate(0f,rotaciony,0* Time.deltaTime);


        if (enpartida ==true) { 
        //Debug.Log("Está jugando");
            //tiempo
        tiempoquehatardado = tiempoquehatardado +Time.deltaTime;
            

        }
       
    }





    float rotaciony = 0.5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player")) {

            Debug.Log("¡El jugador ha recogido una moneda");
            gameObject.SetActive(false);

            contadormonedas.monedas++;
            contador.text = contadormonedas.monedas.ToString();
        }

        if (contadormonedas.monedas == 9)
        {
            pantallavictoria.SetActive(true);
            other.GetComponent<Jugador>().enabled = false;
          
            desactivarenemigo();

            //tiempo
            enpartida = false;
        
            tiempo.text = tiempoquehatardado.ToString();
            Debug.Log("Has recogido todas las monedas!!");
           
        }
           
    }

    private void desactivarenemigo()
    {
        enemigoscript.enabled = false;
    }

   
}
