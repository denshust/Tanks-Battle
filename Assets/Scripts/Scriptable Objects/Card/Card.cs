using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardData cardData;

    public TMP_Text cardNameText;
    public Image cardBgImage;
    public Image cardImage;
    public TMP_Text cardDescriptionText;
    public TMP_Text cardNumberText;

    void Start()
    {
        cardNameText.text = cardData.cardName;
        cardBgImage.color = cardData.cardBgColor;
        cardImage.sprite = cardData.cardSprite;
        cardDescriptionText.text = cardData.cardDescription;
        cardNumberText.text = cardData.cardNumber.ToString();
    }
}
