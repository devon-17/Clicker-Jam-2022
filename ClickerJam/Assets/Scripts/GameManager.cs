using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 15;
    public float timeStartAmount = 5;
    public int money;

    private bool moneyNeedsToIncrease;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        
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

    public void StartTimer(){
        isClicked = true;
    }

    public void TimerManager(){
        //buggy
        if(isClicked){
            timer -= Time.deltaTime;
            isClicked = false;
        }
        if(timer <= 0){
            timer = timeStartAmount;
        }
    }
}
