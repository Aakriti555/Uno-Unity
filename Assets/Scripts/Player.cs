using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
public string playerName; 
public List<CardDisplay> playerHand; 
public Player(string name) 
{
playerName = name; 
playerHand = new List<CardDisplay>(); 

}
public void DrawCard (CardDisplay cardDisplay) 
{

playerHand.Add(cardDisplay); 
}
public void PlayCard (CardDisplay cardDisplay) 
{

playerHand. Remove (cardDisplay);
}
}
