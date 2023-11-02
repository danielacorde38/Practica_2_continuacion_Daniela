using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    GameObject derrota;
  

    //movimiento del jugador
    public float movimientoejex;
    public float movimientoejey;
    public float movimientoejez;
    float velocidadmovimiento = 6f;

    
    //Para que el jugador salte
    public float salto;
    public Rigidbody rg;
    public float empuje = 0.5f;

    // Para que cuando salte no pueda spamear el espacio
    bool tocatierra=false;
    

    private void Start()
    {
        rg = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //Para acceder a los controles de movimiento

        movimientoejex = - Input.GetAxis ("Horizontal") * Time.deltaTime * velocidadmovimiento;
        movimientoejez = - Input.GetAxis ("Vertical")* Time.deltaTime * velocidadmovimiento;

        

        transform.Translate(movimientoejex, movimientoejey, movimientoejez);

        if (Input.GetKeyDown(KeyCode.Space) && tocatierra == true)
        {
            Jump();
        }

        derrota.SetActive(false);

       
        

    }

    // Para que cuando salte no pueda spamear el espacio
    public void Jump()
    {
        tocatierra = false;
        rg.AddForce(0, empuje, 0, ForceMode.Impulse);
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("suelo")) { //saltar

            tocatierra = true;
        }

        if(collision.gameObject.CompareTag ("enemigo")) //morir por enemigo

        {
            
            gameObject.SetActive (false);//se desactive el jugador
            derrota.SetActive(true); //se activa la pantalla de derrota
          

            if (contadormonedas.monedas == 9)
            {

                derrota.SetActive(false);


            }   
        
        }

       
    
    }

    //muerte por caida
   private void OnTriggerEnter(Collider other)
    {
       
        
        if (other.gameObject.CompareTag("caida"))
        {

            gameObject.SetActive (false);
            derrota.SetActive(true);

        } 
       
    }
   
}
