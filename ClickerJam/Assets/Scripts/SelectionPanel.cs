using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionPanel : MonoBehaviour
{
    public GameObject managerBtn;
    public GameObject specialUpgradesBtn;
    public GameObject managersPanel;


    // Start is called before the first frame update
    void Start()
    {
        specialUpgradesBtn.SetActive(true);
        managerBtn.SetActive(true);
        managersPanel.SetActive(false);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (hasManager)
        {
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            if (!parent.item.isClicked)
            {
                parent.item.timer -= Time.deltaTime;
                parent.item.isClicked = true;
            }
            if (parent.item.timer <= 0)
            {
                parent.item.isClicked = true;
                GameManager.instance.AddMoney(parent.item.moneyIncreaseAmount);
                parent.item.timer = parent.item.timeStartAmount;
            }
        }   
    }

    public void ManagerBtnClick()
    {
        if (GameManager.instance.money >= 5)
        {
            //Debug.Log(parent.item.name + "now has a manager"); 
            GameManager.instance.money -= 5;
            hasManager = true;
        }
    }

    */

    public void ManagerPanel()
    {
        Debug.Log("CLICKED");
        
        managersPanel.SetActive(true);
        specialUpgradesBtn.SetActive(false);
        managerBtn.SetActive(false);
    }

    
}
