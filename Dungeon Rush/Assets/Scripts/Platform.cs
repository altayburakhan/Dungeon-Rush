using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG;
using DG.Tweening;

public class Platform : GameManager
{
    //[SerializeField] private GameObject player;
    private IEnumerator delay;
    private Tween _tween;
    
    void Start()
    {
        delay = WaitAndGo(0.3f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            StartCoroutine(delay);
            collision.collider.transform.SetParent(transform);
        }
    }

    private IEnumerator WaitAndGo(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            gameObject.transform.DOMoveZ(10.5f,0.5f).SetEase(Ease.Linear);
        }
    }
}
