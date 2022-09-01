using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject menuBtn;
    public Text menuText;
    public GameObject menu;
    public GameObject gamePanel;

    public float speedDecreaseBuyAmount;
    public float speedDecrease;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        menu.SetActive(false);
        gamePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuBtnClick()
    {
        if (!menu.activeInHierarchy)
        {
            menu.SetActive(true);
            menuText.text = "Close Menu";
            gamePanel.SetActive(false);
        }
        else
        {
            menu.SetActive(false);
            menuText.text = "Menu";
            gamePanel.SetActive(true);
        }
    }

    public void TimerDecrease(){
        if(GameManager.instance.money >= speedDecreaseBuyAmount)
        {
            GameManager.instance.timeStartAmount -= speedDecrease;
            GameManager.instance.timer = GameManager.instance.timeStartAmount;
            GameManager.instance.money -= speedDecreaseBuyAmount;
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            speedDecreaseBuyAmount *= 1.5f;          
        }

        if(GameManager.instance.timeStartAmount <= 0){
            GameManager.instance.timeStartAmount = 0.1f;
            GameManager.instance.timer = 0.1f;
        }   
    }
}
