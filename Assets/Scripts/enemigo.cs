using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{

    public Transform target;
   public float moveSpeed = 4f;
    float rotationSpeed = 6f;
    
    
  


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; 

    }


    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 direccion = target.position - transform.position;

        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed*Time.deltaTime);
        transform.LookAt(target);
    }



}
