using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Object item;
    public bool hasManager;
 
    // Update is called once per frame
    void Update()
    {
        if (hasManager)
        {
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            if (!item.isClicked)
            {
                item.timer -= Time.deltaTime;
                item.isClicked = true;
            }
            if (item.timer <= 0)
            {
                item.isClicked = true;
                GameManager.instance.AddMoney(item.moneyIncreaseAmount);
                item.timer = item.timeStartAmount;
            }
        }
    }

    public void ManagerBtnClick()
    {
        if (GameManager.instance.money >= 5)
        {
            Debug.Log(item.name + "now has a manager"); 
            GameManager.instance.money -= 5;
            hasManager = true;
        }
    }
}
