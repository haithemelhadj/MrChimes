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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vmvnt = Input.GetAxisRaw("Vertical");        
        Hmvnt = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Hmvnt*speed, Vmvnt * speed);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chimes")
        {
            Debug.Log("hit chimes!");
        }
    }



}
