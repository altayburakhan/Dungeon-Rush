using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject coin, nextLevel, exit;

    private void Update()
    {
        if (gameObject)
        {
            StartCoroutine("ShowUI");
        }
    }

    IEnumerator ShowUI()
    {
        yield return new WaitForSeconds(1);
        coin.SetActive(true);
        yield return new WaitForSeconds(1);
        nextLevel.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        exit.SetActive(true);
    }
}
