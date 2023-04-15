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
            GameObject launcher = Instantiate(bullet, transform1.position, bullet.transform.rotation);
            launcher.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,launchSpeed,0)); 
            yield return new WaitForSeconds(2);
        }
        
    }
}
