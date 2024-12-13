using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Game : MonoBehaviour
{
    public TMP_Text ScoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;


    public int shop1prize;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    public int shop3prize;
    public TMP_Text shop3text;

    public TMP_Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public TMP_Text amount2Text;
    public int amount2;
    public float amount2Profit;

    public TMP_Text amount3Text;
    public int amount3;
    public float amount3Profit;






    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
    }

    void Update()
    {
        ScoreText.text = ((int)currentScore).ToString("000") + " $";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        shop1text.text = "" + shop1prize + "";
        shop2text.text = "" + shop2prize + "";
        shop3text.text = "" + shop3prize + "";

        amount1Text.text = " " + amount1 + ":";
        amount2Text.text = " " + amount2 + ":";
        amount3Text.text = " " + amount3 + ":";






    }

    public void Hit()
    {
        currentScore += hitPower;
    }

    public void Shop1()
    {
        if (currentScore >= shop1prize)
        {
            currentScore -= shop1prize;
            amount1 += 1;
            amount1Profit += 1;
            x += 10;
            shop1prize += 25;
        }
    }


    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 1;
            amount2Profit += 1;
            x += 1000000;
            shop2prize += 100;
        }
    }

    public void Shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 1;
            amount3Profit += 1;
            x += 1000000;
            shop3prize += 300;
        }
    }


}