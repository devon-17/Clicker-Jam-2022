using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item/Object To Click", menuName = "Item")]
public class Object : ScriptableObject
{
    public float timer = 15;
    public float timeStartAmount = 5;
    public bool isClicked;
    public float moneyIncreaseAmount;
}
