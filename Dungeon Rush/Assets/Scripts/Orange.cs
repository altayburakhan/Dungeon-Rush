using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    [SerializeField] private GameObject door1, door2;
    private Vector3 newPosition = new Vector3();

    private void Start()
    {
        newPosition = Vector3.down;
    }

    private void OnTriggerEnter(Collider other)
    {
        door1.transform.position = Vector3.Lerp(transform.position,newPosition ,1 );
        door2.transform.position = Vector3.Lerp(transform.position,newPosition ,1 );
    }
}
