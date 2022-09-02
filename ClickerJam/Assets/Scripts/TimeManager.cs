using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;

    public Object item;
    public GameObject timerObj;
    public Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        // when obj is clicked
        if (item.isClicked)
        {
            item.timer -= Time.deltaTime; // start timer

            timerObj.SetActive(true);   
            timerText.text = "Time Left: " + item.timer.ToString("f2");
        }
        if (item.timer <= 0) // when 0
        {
            timerObj.SetActive(false);   
            item.isClicked = false; // obj needs to be clicked again
            GameManager.instance.AddMoney(item.moneyIncreaseAmount); // adding money using our int
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money; // setting text
            // reset timer
            item.timer = item.timeStartAmount;
        }
    }
}
