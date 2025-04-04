using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardColor { Red, Yellow, Green, Blue, Wild }
public enum CardType { Number, Skip, Reverse, DrawTwo, Wild, WildDrawFour }

public class CardDisplay : MonoBehaviour
{
    public CardColor cardColor;
    public CardType cardType;
    public int cardNumber; // Only for Number type

    public Image colorImage; // Background color
    public Image valueImage; // Number or action symbol
    public Sprite[] cardSprites; // Assign in Inspector

    public void InitializeCard(CardColor color, CardType type, int number, Sprite sprite)
    {
        cardColor = color;
        cardType = type;
        cardNumber = number;

        if (colorImage != null)
            colorImage.color = GetColorFromEnum(color); // Set background color

        if (valueImage != null)
            valueImage.sprite = sprite; // Set the correct number/action sprite
    }

    private Color GetColorFromEnum(CardColor color)
    {
        switch (color)
        {
            case CardColor.Red: return Color.red;
            case CardColor.Yellow: return Color.yellow;
            case CardColor.Green: return Color.green;
            case CardColor.Blue: return Color.blue;
            default: return Color.white;
        }
    }
}
