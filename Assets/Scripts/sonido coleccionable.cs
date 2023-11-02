using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidocoleccionable : MonoBehaviour
{
    
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Debug.Log("hola");
            AudioSource coleccionableaudio = other.GetComponent<AudioSource>();
            if (coleccionableaudio != null) {

                audioSource.PlayOneShot(coleccionableaudio.clip);
                Debug.Log("HOLA");
            }

            Destroy(audioSource);
        }
    }

}
