using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Random = UnityEngine.Random;

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
    public float shop2prize;
    public int amount2;
    [Header(":Shop2Text")]
    public TMP_Text shop2text;
    public TMP_Text amount2Text;




    [Header("---------Shop3---------")]
    public float shop3prize;
    public int amount3;
    [Header(":Shop3Text")]
    public TMP_Text shop3text;
    public TMP_Text amount3Text;





    [Header("---------Click---------")]
    public int upgradePrize;
    [Header(":ClickText")]
    public TMP_Text upgradeText;

    public GameObject plusObject;
    public Text plusText;






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

        plusText.text = " + " + hitPower;






    }

    public void Hit()
    {
        currentScore += hitPower;
        plusObject.SetActive(false);
        plusObject.transform.position = new Vector3(Random.Range(-92, -92), Random.Range(80, 80 ), 63);
        plusObject.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(Fly());
            
            
            
            
            
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
            x += 8;
            shop2prize *= 1.15f;
            shop2prize = Mathf.Ceil(shop2prize);

        }
    }

    public void Shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 1;
            x += 50;
            shop3prize *= 1.15f;
            shop3prize = Mathf.Ceil(shop3prize);
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


    IEnumerator Fly()
    {
        for (int i = 0; i <= 19; i++) ;
        {
            yield return new WaitForSeconds(0.01f);
            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y + 2, 0);

        }

        plusObject.SetActive(false);
    }


}