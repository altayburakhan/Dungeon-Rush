using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : GameManager
{
    [SerializeField] protected float zTpValue, yTpValue, xTpValue;
    private GridMovement _gridMovement;
    private void Start()
    {
        _gridMovement = GameObject.Find("Player").GetComponent<GridMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Teleporting");
    }

    IEnumerator Teleporting()
    {
        player.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        player.transform.position = new Vector3(xTpValue, yTpValue, zTpValue);
        yield return new WaitForSeconds(0.3f);
        player.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _gridMovement.isMoving = false;
    }
}
