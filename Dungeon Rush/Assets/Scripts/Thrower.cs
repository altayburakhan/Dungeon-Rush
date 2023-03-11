using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] private float launchSpeed;

    private void Start()
    {
        StartCoroutine("Launcher");
    }
    
    IEnumerator Launcher()
    {
        while (true)
        {
            var transform1 = transform;
            GameObject launcher = Instantiate(bullet, transform1.position, transform1.rotation);
            launcher.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,-launchSpeed)); 
            yield return new WaitForSeconds(2);
        }
        
    }
}
