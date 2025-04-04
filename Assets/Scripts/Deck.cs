
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform deckParent;
    public Sprite[] numberSprites; // Assign in Inspector
    public Sprite drawTwoSprite, reverseSprite, skipSprite, wildSprite, wildDrawFourSprite;

    private void Start()
    {
        GenerateDeck();
    }

    void GenerateDeck()
    {
        CardColor[] colors = { CardColor.Red, CardColor.Yellow, CardColor.Green, CardColor.Blue };

        foreach (CardColor color in colors)
        {
            for (int i = 0; i <= 9; i++) // Number Cards
            {
                CreateCard(color, CardType.Number, i, numberSprites[i]);
                if (i != 0) CreateCard(color, CardType.Number, i, numberSprites[i]); // Duplicate except 0
            }

            CreateCard(color, CardType.DrawTwo, -1, drawTwoSprite);
            CreateCard(color, CardType.Reverse, -1, reverseSprite);
            CreateCard(color, CardType.Skip, -1, skipSprite);
        }

        // Wild Cards
        for (int i = 0; i < 4; i++)
        {
            CreateCard(CardColor.Wild, CardType.Wild, -1, wildSprite);
            CreateCard(CardColor.Wild, CardType.WildDrawFour, -1, wildDrawFourSprite);
        }
    }

    void CreateCard(CardColor color, CardType type, int number, Sprite sprite)
    {
        GameObject newCard = Instantiate(cardPrefab, deckParent);
        CardDisplay cardDisplay = newCard.GetComponent<CardDisplay>();
        cardDisplay.InitializeCard(color, type, number, sprite);
    }

}
