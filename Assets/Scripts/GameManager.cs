using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Card;
    public static int TotalCards;
    //[SerializeField] public static  List<Card> Cards; // list of cards empty but adds 1 value when player picks a card
    //[NonSerialized] public static  List<Card> Cards = new List<Card>(); // list of cards empty but adds 1 value when player picks a card

    public static int NumberOfSolvedCards ;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        TotalCards = Card.transform.childCount;
    }

    private void Update()
    {
        if (NumberOfSolvedCards  >= TotalCards)//check if all cards are solved
        {
            //load next level
            NextLevel();            
        }
    }

    // Update is called once per frame
    public static void CheckCards()
    {/*
        if(Cards.Count>=2) //check if 2 cards are picked
        {
            if (Cards[0].faceSprite.name == Cards[1].faceSprite.name) // check if the two cards have the same face sprite
            {

                Cards[0].SetCollToInactive();//set the card collider to inactive from card script
                Cards[1].SetCollToInactive();
                Debug.Log("cards are the same");
                
            }
            else
            {
                Debug.Log("cards are not the same");
                Cards[0].RotateCardCoroutineCalled();
                Cards[1].RotateCardCoroutineCalled();
                
            }
            Cards.Clear();//clear the list of cards
        }        
    */
    }
    
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public static void NextLevel()
    {
        NumberOfSolvedCards = 0;
        TotalCards = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
