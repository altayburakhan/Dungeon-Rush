using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor;

public class Monsters : MonoBehaviour
{
    public PathType pathType = PathType.Linear;
    Tween _tween;
    [SerializeField] private Transform monster;
    [SerializeField] Vector3[]  pathValue = new Vector3[20];
    [SerializeField] private float duration;

    private void Start()
    { 
        _tween = monster.transform.DOPath(pathValue, duration, pathType);
        _tween.SetEase(Ease.Linear).SetLoops(-1);
    }

}
