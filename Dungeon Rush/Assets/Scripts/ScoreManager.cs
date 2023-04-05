using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] private TextMeshProUGUI coinText;
    protected int score = 0;
    private void Start()
    {
        instance = this;
        coinText.text = score.ToString();
    }

    public void ChangeScore(int coin)
    {
        score += coin;
        coinText.text = score.ToString();
    }

}

