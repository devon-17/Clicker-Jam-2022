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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ManagerPanel()
    {
        Debug.Log("CLICKED");
        managersPanel.SetActive(true);
        specialUpgradesBtn.SetActive(false);
        managerBtn.SetActive(false);
    }

    public void ManagerBtnClick(Object item)
    {
        Debug.Log("CLICKED");
        if (GameManager.instance.money >= 5)
        {
            if (item.timer <= 0)
            {
                item.isClicked = true; // resets the timer again
                GameManager.instance.AddMoney(item.moneyIncreaseAmount); // adding money using our int
                GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2"); // setting text
                                                                                                              // reset timer
                item.timer = item.timeStartAmount;
            }
        }
    }
}
