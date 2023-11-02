using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform player;
    public float speed = 50f;
    public float distancia = 3f;
    public float altura = 3f;

    
    void Update()
    {
        if(player == null) {

            return;
        }
        Vector3 direccion = player.position - transform.position;
        direccion.y = 0;

        Vector3 posicion= player.position - direccion.normalized * distancia;

        posicion.y = player.position.y * altura;
        transform.position = Vector3.MoveTowards(transform.position, posicion, speed*Time.deltaTime);

        transform.LookAt(player, Vector3.up);



    }
}
