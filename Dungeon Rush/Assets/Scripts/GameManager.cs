using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
   public GameObject player;
   protected bool isDead;

   IEnumerator Waiting()
   {
      yield return new WaitForSeconds(1);
   }

   private void Start()
   {
      //Instantiate(player, new Vector3(0.5f, 0.13f, 0.5f), Quaternion.identity);
   }
}
