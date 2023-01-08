using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuffle_cards : MonoBehaviour
{
    /*
    [SerializeField] private GameObject CardShuffler;
    [SerializeField] private GameObject[] Cards;
    */
    // Start is called before the first frame update
    void Start()
    {
        /*
        gameObject.GetComponent<SpriteRenderer>().sprite = CardShuffler.GetComponent<SpriteRenderer>().sprite;
        //add all children to array
        Cards = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Cards[i] = transform.GetChild(i).gameObject;
        }
        //shuffle array
        for (int i = 0; i < Cards.Length; i++)
        {
            GameObject temp = Cards[i];
            int randomIndex = Random.Range(i, Cards.Length);
            Cards[i] = Cards[randomIndex];
            Cards[randomIndex] = temp;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
