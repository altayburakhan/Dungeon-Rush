using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ScoreManager
{
    public int coinValue = 1; // Value of the coin
    public AudioClip coinSound; // Sound effect when the coin is collected

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Update the score
            instance.ChangeScore(coinValue);
            // Play the coin collection sound
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
