using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using DG;
using DG.Tweening;

public class Snakes : MonoBehaviour
{
   public GameObject dummyPrefab;
   public GameObject bodyPrefab;
   public GameObject tailPrefab;
   
   public PathType pathType = PathType.Linear;
   
   public GameManager gameManager;
   
   Tween _tween;
   [SerializeField] Vector3[]  pathValue = new Vector3[6];
   [SerializeField] private float duration;

   private List<GameObject> BodyParts = new List<GameObject>();
   private List<Vector3> PositionHistory = new List<Vector3>();
   [SerializeField] private int delay = 10;
   [SerializeField] private float bodySpeed = 5;
   private void Start()
   {
      SnakeDummy();
      SnakeBody();
      SnakeTail();
      _tween = transform.DOPath(pathValue, duration, pathType);
      _tween.SetEase(Ease.Linear).SetLoops(-1);
   }

   private void Update()
   {
      PositionHistory.Insert(0,transform.position);

      int index = 0;
      foreach (var body in BodyParts)
      {
         Vector3 point = PositionHistory[Mathf.Min(index * delay, PositionHistory.Count - 1)];
         Vector3 moveDirection = point - body.transform.position;
         body.transform.position += moveDirection * bodySpeed * Time.deltaTime;
         body.transform.LookAt(point);
         transform.LookAt(2 * transform.position - point);
         index++;
      }
   }
   

   void SnakeBody()
   {
      GameObject bodyC = Instantiate(bodyPrefab);
      BodyParts.Add(bodyC);
      bodyC.GetComponent<Killing>().player = gameManager.player;
   }

   void SnakeTail()
   {
      GameObject tail = Instantiate(tailPrefab);
      BodyParts.Add(tail);
      tail.GetComponent<Killing>().player = gameManager.player;
   }
   void SnakeDummy()
   {
      GameObject dummy = Instantiate(dummyPrefab);
      BodyParts.Add(dummy);
   }
   

}
