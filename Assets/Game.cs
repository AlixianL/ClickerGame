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

    public TMP_Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public TMP_Text amount2Text;
    public int amount2;
    public float amount2Profit;

    public int upgradePrize;
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
        ScoreText.text = (int)currentScore + " $";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        shop1text.text = "Tier 1:" + shop1prize + "$";
        shop2text.text = "Tier 2:" + shop2prize + "$";

        amount1Text.text = " Tier 1:" + amount1 + "arts $:" + amount1Profit + "/s";
        amount2Text.text = " Tier 2:" + amount2 + "arts $:" + amount2Profit + "/s";

        upgradeText.text = "Cost :" + upgradePrize + " $";




    }

    public void Hit()
    {
        currentScore += hitPower;
    }

    public void Shop1()
    {
        if(currentScore>=shop1prize)
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

    public void Upgrade()
    {
        if(currentScore>=upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
        }
    }

}
