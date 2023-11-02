using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class plataformas : MonoBehaviour
{
   
    [SerializeField]
    Material paredpordefecto;
    [SerializeField]
    Material alcolisionar;


    bool paredroja = false;
    float tiempoenrojo = 1.5f;

    private void Update()

    {
        if (paredroja == true)
        {
            tiempoenrojo = tiempoenrojo - Time.deltaTime;
            if (tiempoenrojo < 0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = paredpordefecto;
                paredroja = false;
                tiempoenrojo = 1.5f;
                gameObject.SetActive(false);

            }
        }


    }


    private void OnCollisionEnter(Collision col)
    {

        gameObject.GetComponent<MeshRenderer>().material = alcolisionar;
        paredroja = true;

    }
}

