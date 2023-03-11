using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : GameManager
{
    
    private void OnParticleCollision(GameObject other)
    {
        if (other == player)
        {
            Debug.Log("lolol");
        }
    }
}
