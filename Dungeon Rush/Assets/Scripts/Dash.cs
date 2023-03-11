using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;
using DG;
using DG.Tweening;

public class Dash : GameManager
{
    [SerializeField] protected  float zValue, yValue ,xValue , duration;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.DOMove(new Vector3(xValue, yValue, zValue),duration);
        StartCoroutine("Waiting");
    }
    
    
}
