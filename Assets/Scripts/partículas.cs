using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partículas : MonoBehaviour
{
    public GameObject particula;
    public float duraciónpartículas = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Recogercoleccionable();

        }
    }
    void Recogercoleccionable()
    {
        //guarda la posicion del personaje
        Vector3 posicionColeccionable =transform.position;
        
        //genera las particulas en la posivcion del coleccionable
        GameObject particulas = Instantiate(particula, posicionColeccionable, Quaternion.identity);

        //Configura la duración
        ParticleSystem.MainModule mainModule = particulas.GetComponent<ParticleSystem>().main;
        mainModule.startLifetime = duraciónpartículas;


    }
}
