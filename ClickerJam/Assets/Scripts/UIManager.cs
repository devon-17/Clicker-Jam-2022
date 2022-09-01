using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject menuBtn;
    public Text menuText;
    public GameObject menu;
    public GameObject gamePanel;
    public float speedDecrease;

    // Start is called before the first frame update
    void Start()
    {
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

    public void SpeedIncrease(){
        GameManager.instance.timeStartAmount -= speedDecrease;
    }
}
