using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{                                   
    public Object item;
    public Button button;
    public GameObject ownedText;
    public bool hasManager;                                     
 
    void Start()
    {
        ownedText.SetActive(false);
    }

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
        if (GameManager.instance.money >= item.toBuyManagerPrice)
        {
            Debug.Log(item.name + " now has a manager"); 
            GameManager.instance.money -= item.toBuyManagerPrice;
            hasManager = true;
            button.interactable = false;
            ownedText.SetActive(true);
        }
    }
}
