using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card Data", menuName = "Custom/Card Data")]
public class CardData : ScriptableObject 
{

    public string cardName = "Default Name";
    public Color cardBgColor = Color.black;
    public Sprite cardSprite;
    public string cardDescription = "None";
    public int cardNumber;
}
