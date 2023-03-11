using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
   public GameObject player;
   protected bool isDead;

   IEnumerator Waiting()
   {
      yield return new WaitForSeconds(1);
   }
   
}
