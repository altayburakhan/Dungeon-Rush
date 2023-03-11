using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridNearCheck : MonoBehaviour
{
    [SerializeField] GridMovement gridMovement;
    
    private void OnTriggerStay(Collider other)
    {
        if (gameObject.name == "rightCube" && other.gameObject.CompareTag("Wall"))
        {
           gridMovement.canRight = false;
        }

        if (gameObject.name == "leftCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canLeft = false;
        }

        if (gameObject.name == "frontCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canFront = false;
        }

        if (gameObject.name == "backCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canBack = false;
        }
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "rightCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canRight = true;
        }

        if (gameObject.name == "leftCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canLeft = true;
        }

        if (gameObject.name == "frontCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canFront = true;
        }

        if (gameObject.name == "backCube" && other.gameObject.CompareTag("Wall"))
        {
            gridMovement.canBack = true;
        }
    }
}
