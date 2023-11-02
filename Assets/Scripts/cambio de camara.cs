using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodecamara : MonoBehaviour
{
    public Camera camaratercerapersona; 
    public Camera camaraprimerapersona; 

    private bool modoPlanoGeneral = false;

    void Start()
    {
        // Inicialmente, activa la cámara de tercera persona y desactiva la cámara de plano general.
        camaratercerapersona.enabled = true;
        camaraprimerapersona.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            modoPlanoGeneral = !modoPlanoGeneral;
            CambiarModoCamara(modoPlanoGeneral);
        }
    }

    void CambiarModoCamara(bool planoGeneral)
    {
        if (planoGeneral)
        {
            // Modo Plano General
            camaratercerapersona.enabled = false;
            camaraprimerapersona.enabled = true;
        }
        else
        {
            // Modo Tercera Persona
            camaratercerapersona.enabled = true;
            camaraprimerapersona.enabled = false;
        }
    }

}
