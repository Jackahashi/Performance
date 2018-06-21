using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;


    float timeLeft = 100.0f;

    public Text Timetext;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        Timetext.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            Timetext.text = "Game Over, Man!";
        }
    }
}

