using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TimeManager timeManager;
    public GameObject upgradeBtn;
    public Text costTxt;
    public Color cannotBuyColor;
    public Color canBuyColor;
    public Text upgradesLeftTxt;

    public float upgradeBuyAmount;

    public float moneyMultiplier;

    public int upgradesLeft = 25;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //menu.SetActive(false);
        //gamePanel.SetActive(true);

        upgradesLeftTxt.text = "Upgrades Left: " + upgradesLeft;
    }

    // Update is called once per frame
    void Update()
    {
        CostManager();
    }

    public void UpragdeBtnClick(){
        if(GameManager.instance.money >= upgradeBuyAmount && upgradesLeft > 0)
        {
            Debug.Log(timeManager.item);
            timeManager.item.moneyIncreaseAmount *= moneyMultiplier;
            GameManager.instance.money -= upgradeBuyAmount;
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            upgradeBuyAmount *= 1.1f;

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

    public void SpeedDecrease(){
        if(upgradesLeft == 23){
            Upgrade();
        }
    }

    public void Upgrade(){
        timeManager.item.timer *= 0.5f;
        timeManager.item.timeStartAmount *= 0.5f;
    }
}
