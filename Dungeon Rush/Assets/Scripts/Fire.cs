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
    }

    private void Update()
    {
        StartCoroutine("FireTime");
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
        fire.Play();
        yield return new WaitForSeconds(2);
        fire.Stop();
    }
}
