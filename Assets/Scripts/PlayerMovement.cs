using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public bool isplayer1;
    public float speed=5f;
    public Rigidbody2D rb;
    private float Vmvnt;
    private float Hmvnt;
    private int Health=3;
    
    // Update is called once per frame
    void Update()
    {
        Vmvnt = Input.GetAxisRaw("Vertical");        
        Hmvnt = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Hmvnt, Vmvnt).normalized*speed;
        if (Health <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 1;// 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chimes")
        {
            Debug.Log("hit chimes!");
            Time.timeScale = 0;
            Health--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chimes")
        {
            Debug.Log("hit chimes!");
            Time.timeScale = 0;
            Health--;
        }
    }
}
