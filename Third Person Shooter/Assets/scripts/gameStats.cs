using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class gameStats : MonoBehaviour
{
    public int Score;

    public TMP_Text scoreText;

    void Start()
    {
        Score = 0;
    }

    void FixedUpdate()
    {

        scoreText.text = "Score: " + Score.ToString();

    }


}
