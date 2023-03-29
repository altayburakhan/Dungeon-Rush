using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fire : GameManager
{
    private ParticleSystem fire;

    private void Start()
    {
        fire = GetComponent<ParticleSystem>();
        StartCoroutine("FireTime");
    }

    private void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other == player)
        {
            Debug.Log("lolol");
        }
    }

    IEnumerator FireTime()
    {
        //fire.Play();
        
        //fire.Play();
        
        while (true)
        {
            yield return new WaitForSeconds(2);
            fire.Stop();
            yield return new WaitForSeconds(2); 
            fire.Play();
        }
    }
}
