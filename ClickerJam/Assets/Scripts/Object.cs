using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Item To Click")]
public class Object : ScriptableObject
{
    public float timer = 15;
    public float timeStartAmount = 5;
    public bool isClicked;
    public float moneyIncreaseAmount;
    public float toBuyManagerPrice;
}
