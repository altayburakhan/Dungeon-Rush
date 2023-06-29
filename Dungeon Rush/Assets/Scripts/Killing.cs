using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Killing : GameManager
{
    public Animator _animator;
    public static readonly int IsDead = Animator.StringToHash("IsDead");
    private void Start()
    {
        //_animator =  GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isDead = true;
            Debug.Log("dead");
            _animator.SetBool(IsDead, true);
        }
    }
}
