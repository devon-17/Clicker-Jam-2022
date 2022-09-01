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

    public GameObject upgradeBtn;
    public Text costTxt;
    public Color cannotBuyColor;
    public Color canBuyColor;

    public Text upgradesLeftTxt;

    public float upgradeBuyAmount;

    public int upgradesLeft = 25;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        menu.SetActive(false);
        gamePanel.SetActive(true);

        upgradesLeftTxt.text = "Upgrades Left: " + upgradesLeft;
    }

    // Update is called once per frame
    void Update()
    {
        CostManager();
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

    public void UpragdeBtnClick(){
        if(GameManager.instance.money >= upgradeBuyAmount && upgradesLeft > 0)
        {
            GameManager.instance.moneyIncreaseAmount *= 1.3f;
            GameManager.instance.money -= upgradeBuyAmount;
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            upgradeBuyAmount *= 1.5f;

            upgradesLeft --;

            upgradesLeftTxt.text = "Upgrades Left: " + upgradesLeft;
        }
    }

    public void CostManager(){
        costTxt.text = "$" + upgradeBuyAmount.ToString("f2");

        if(GameManager.instance.money < upgradeBuyAmount){
            upgradeBtn.GetComponent<Image>().color = cannotBuyColor;
        }else if(GameManager.instance.money >= upgradeBuyAmount){
            upgradeBtn.GetComponent<Image>().color = canBuyColor;
        }
    }
}
