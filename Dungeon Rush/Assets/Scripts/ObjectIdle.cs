using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIdle : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time * 2) * 0.1f + 0.4f, transform.position.z);
        transform.Rotate(0, 0.2f, 0);
        
    }
}
