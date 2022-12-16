using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
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
        if (coroutineAllowed && Input.GetKeyDown(KeyCode.Space) && TouchingPlayer)// && !facedUp)
        {
            Debug.Log("count=" + GameManager.Cards.Count);
            StartCoroutine(RotateCard());
            GameManager.Cards.Add(this);
            GameManager.CheckCards();
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
    
        

