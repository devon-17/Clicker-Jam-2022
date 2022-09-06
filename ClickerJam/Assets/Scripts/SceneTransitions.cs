using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitions : MonoBehaviour
{
    private GameObject gameCanvas;
    public GameObject animObj;
    public float timeMachineCost;
    public string sceneToGoTo;
    public Text costText;

    void Start()
    {
        gameCanvas = GameObject.Find("Canvas");
        StartCoroutine(PortalAnim());
        if(costText)
            costText.text = "Cost: $" + timeMachineCost.ToString("f2");
    }

    public void MoveScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void BuyTimeMachine()
    {
        if(GameManager.instance.money >= timeMachineCost)
        {
            GameManager.instance.money -= timeMachineCost;
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money.ToString("f2");
            MoveScene(sceneToGoTo);
        }
    }

    public IEnumerator PortalAnim(){
        gameCanvas.SetActive(false);
        yield return new WaitForSeconds(3f);
        gameCanvas.SetActive(true);
        animObj.SetActive(false);
    }

}
