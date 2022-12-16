using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public static GameObject[] Cards;
    [SerializeField] public  static List<Card> Cards; // list of cards empty but adds 1 value when player picks a card

    
    // Update is called once per frame
    public static void CheckCards()
    {
        if(Cards.Count==2) //check if 2 cards are picked
        {
            if (Cards[0].faceSprite.name == Cards[1].faceSprite.name) // check if the two cards have the same face sprite
            {

                Cards[0].SetCollToInactive();//set the card collider to inactive from card script
                Cards[1].SetCollToInactive();
                Cards.Clear();//clear the list of cards
            }
            else
            {
                /*
                StartCoroutine(Cards[0].RotateCard());//rotate the cards back from card script
                StartCoroutine(Cards[1].RotateCard());
                */
                Cards[0].RotateCardCoroutineCalled();
                Cards[1].RotateCardCoroutineCalled();
            }
        }
        
    }
    
}
