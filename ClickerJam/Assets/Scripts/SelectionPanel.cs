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

    public void ManagerPanel()
    {   
        managersPanel.SetActive(true);
        specialUpgradesBtn.SetActive(false);
        managerBtn.SetActive(false);
    }
    public void CloseManagerPanel()
    {
        managersPanel.SetActive(false);
        specialUpgradesBtn.SetActive(true);
        managerBtn.SetActive(true);
    }

}
