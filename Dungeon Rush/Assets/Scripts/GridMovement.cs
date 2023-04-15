using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
/*using UnityEngine.Windows.Speech;*/

public class GridMovement : MonoBehaviour
{

    private Vector3 originalPosition, targetPosition;
    [SerializeField] private GameObject character;
    [SerializeField] private AudioClip dashSound;
    public bool canLeft, canRight, canFront, canBack;
    private float timeToMove = 0.2f;
    public bool isMoving;
    private Animator _animator;
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");


    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isMoving && canFront)
        {
            StartCoroutine(MovePlayer(Vector3.forward));
            AudioSource.PlayClipAtPoint(dashSound, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.A) && !isMoving && canLeft)
        {
            StartCoroutine(MovePlayer(Vector3.left));
            AudioSource.PlayClipAtPoint(dashSound, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.D) && !isMoving && canRight)
        {
            StartCoroutine(MovePlayer(Vector3.right));
            AudioSource.PlayClipAtPoint(dashSound, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.S) && !isMoving && canBack)
        {
            StartCoroutine(MovePlayer(Vector3.back));
            AudioSource.PlayClipAtPoint(dashSound, transform.position);
        }
    }
    

    private IEnumerator MovePlayer(Vector3 direction)
    {
        character.transform.rotation = Quaternion.LookRotation(direction);
        isMoving = true; 
        _animator.SetBool(IsMoving, true);
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
        _animator.SetBool(IsMoving, false);
    }
    

}
