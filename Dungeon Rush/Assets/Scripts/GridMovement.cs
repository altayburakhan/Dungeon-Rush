using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/*using UnityEngine.Windows.Speech;*/

public class GridMovement : MonoBehaviour
{

    private Vector3 originalPosition, targetPosition;
    public bool canLeft, canRight, canFront, canBack;
    private float timeToMove = 0.2f;
    public bool isMoving;

    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isMoving && canFront)
        {
            StartCoroutine(MovePlayer(Vector3.forward));
        }

        if (Input.GetKeyDown(KeyCode.A) && !isMoving && canLeft)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }

        if (Input.GetKeyDown(KeyCode.D) && !isMoving && canRight)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }

        if (Input.GetKeyDown(KeyCode.S) && !isMoving && canBack)
        {
            StartCoroutine(MovePlayer(Vector3.back));
        }

    }
    

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        
        float elapsedTime = 0;
        
        originalPosition = transform.position;
        targetPosition = originalPosition + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(originalPosition, targetPosition, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        
        isMoving = false;
    }

}