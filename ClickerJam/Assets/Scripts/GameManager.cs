using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("TIMER")]
    public float timer = 15;
    public float timeStartAmount = 5;
    public GameObject timerObj;
    public Text timerText;

    [Header("MONEY")]
    public int money;
    public int moneyIncreaseAmount;
    public Text moneyText;

    private bool moneyNeedsToIncrease;
    private bool isClicked;

    void Start(){
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        TimerManager();
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }

    // event trigger component on obj
    public void StartTimer()
    {
        isClicked = true;
    }

    public void TimerManager()
    {
        // when obj is clicked
        if (isClicked)
        {
            timer -= Time.deltaTime; // start timer

            // activating timer obj and setting text
            timerObj.SetActive(true);
            timerText.text = "Time Left: " + timer.ToString("f2");

            // money needs to increase so we can add money
            moneyNeedsToIncrease = true;
        }
        if (timer <= 0) // when 0
        {
            timerObj.SetActive(false); // setting timer text to false
            isClicked = false; // obj needs to be clicked again
            AddMoney(moneyIncreaseAmount); // adding money using our int
            moneyText.text = "Money: " + money; // setting text
            moneyNeedsToIncrease = false; // telling game we have our money for that click
            // reset timer
            timer = timeStartAmount;
        }
    }
}
