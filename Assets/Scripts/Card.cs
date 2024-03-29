using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public static List<Card> Cards = new List<Card>();//duplicate 

    private SpriteRenderer rend;
    //public GameObject GameManager;

    [SerializeField]
    public Sprite faceSprite, backSprite;
    [SerializeField] private Collider2D coll;

    private bool coroutineAllowed, facedUp;
    [SerializeField] private bool TouchingPlayer = false;
    [SerializeField] private float WaitTimer;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = backSprite;
        coroutineAllowed = true;
        facedUp = false;
    }
    //-------------------------------------------------------
    public void RotateCardCoroutineCalled()
    {
        StartCoroutine(RotateCard());
    }
    //-------------------------------------------------------

    public void Update()
    {
        if (coroutineAllowed && Input.GetKeyDown(KeyCode.Space) && TouchingPlayer && Cards.Count<2 && !facedUp)
        {
            
            StartCoroutine(RotateCard());
            Cards.Add(this);
            GameManager.CheckCards();
            Debug.Log("count=" + Cards.Count);
        }
    }

    public IEnumerator RotateCard()
    {
        coroutineAllowed = false;

        if (!facedUp)
        {
            for (float i = 0f; i <= 180f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    rend.sprite = faceSprite;
                }
                yield return new WaitForSeconds(WaitTimer);
            }
        }

        else if (facedUp)
        {
            for (float i = 180f; i >= 0f; i -= 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    rend.sprite = backSprite;
                }
                yield return new WaitForSeconds(WaitTimer);
            }
        }

        coroutineAllowed = true;

        facedUp = !facedUp;
        //-------- i added this
        if (Cards.Count >= 2 && Cards[0].facedUp && Cards[1].facedUp)
        {
            

            if (Cards[0].faceSprite.name == Cards[1].faceSprite.name) // check if the two cards have the same face sprite
            {
                //9erd yawli ya3ml sound for 5secs w yzid fel speed
                Cards[0].SetCollToInactive();//set the card collider to inactive from card script
                Cards[1].SetCollToInactive();
                Debug.Log("cards are the same");
                GameManager.NumberOfSolvedCards +=2;

            }
            else if (Cards[0].faceSprite.name != Cards[1].faceSprite.name)//check if the two cards have different face sprites
            {
                
                Cards[0].RotateCardCoroutineCalled();//rotate both cards if not the same
                Cards[1].RotateCardCoroutineCalled();
                Debug.Log("cards are not the same");

            }
            else//print error if there is an error
            {
                Debug.Log("error");
            }
            Cards.Clear();//clear list of 2 cards to fill with two new cards if player picks two new cards
            
        }




        //-------end my add
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player is in the trigger");
            TouchingPlayer = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player is in the trigger");
            TouchingPlayer = false;

        }
    }
    public void SetCollToInactive()
    {
        coll.enabled = false;
    }
}
    
        

