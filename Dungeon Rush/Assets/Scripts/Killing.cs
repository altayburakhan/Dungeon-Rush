using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Killing : GameManager
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isDead = true;
            Debug.Log("dead");
        }
    }
}
