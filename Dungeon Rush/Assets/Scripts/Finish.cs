using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject LevelComplete;

    private void OnCollisionEnter(Collision collision)
    {
        LevelComplete.SetActive(true);
    }
}
