using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public Object item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when obj is clicked
        if (item.isClicked)
        {
            item.timer -= Time.deltaTime; // start timer

            //Instantiates the Object
            GameObject textBox = (GameObject)Instantiate(item.timerObj, transform.position, transform.rotation);
 
            //Grabs the TextMesh component from the game object
            TextMesh theText = textBox.transform.GetComponent<TextMesh>();
 
            //Sets the text.
            theText.text = "Time Left: " + item.timer.ToString("f2");
        }
        if (item.timer <= 0) // when 0
        {
            item.timerObj.SetActive(false); // setting timer text to false
            item.isClicked = false; // obj needs to be clicked again
            GameManager.instance.AddMoney(item.moneyIncreaseAmount); // adding money using our int
            GameManager.instance.moneyText.text = "Money: $" + GameManager.instance.money; // setting text
            // reset timer
            item.timer = item.timeStartAmount;
        }
    }
}
