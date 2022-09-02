using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    

    [Header("TIMER")]
    public float timer;
    public float timeStartAmount = 5;
    public GameObject timerObj;
    public Text timerText;

    [Header("MONEY")]
    public float money;
    public float moneyIncreaseAmount;
    public Text moneyText;

    private bool moneyNeedsToIncrease;


    void Start(){
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        //TimerManager();
    }

    public void AddMoney(float amount)
    {
        money += amount;
    }

    // event trigger component on obj
    public void StartTimer(Object item)
    {
        item.isClicked = true;     
    }
}
