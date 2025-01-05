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

    [Header("---------Shop1---------")]
    public float shop1prize;
    public int amount1;
    [Header(":Shop1Text")]
    public TMP_Text shop1text;
    public TMP_Text amount1Text;



    [Header("---------Shop2---------")]
    public int shop2prize;
    public int amount2;
    public float amount2Profit;
    [Header(":Shop2Text")]
    public TMP_Text shop2text;
    public TMP_Text amount2Text;




    [Header("---------Shop3---------")]
    public int shop3prize;
    public int amount3;
    public float amount3Profit;
    [Header(":Shop3Text")]
    public TMP_Text shop3text;
    public TMP_Text amount3Text;





    [Header("---------Click---------")]
    public int upgradePrize;
    [Header(":ClickText")]
    public TMP_Text upgradeText;






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

        upgradeText.text = "Cost :" + upgradePrize + " $";






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
            x += 1;
            shop1prize *= 1.15f;
            shop1prize = Mathf.Ceil(shop1prize);
        }
    }


    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 1;
            amount2Profit += 1;
            x += 8;
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


    public void Upgrade()
    {
        if (currentScore >= upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
        }
    }


}