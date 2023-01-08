using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MrChimesCode : MonoBehaviour
{
    [SerializeField] private float x, y;
    [SerializeField] private float Speed;
    [SerializeField] private float Xvalue, Yvalue;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Xvalue = Random.Range(0.1f, 1f);
        Yvalue = Random.Range(0.1f, 1f);
        x = Random.Range(0, 2) == 0 ? -1 : 1;
        y = Random.Range(0, 2) == 0 ? -1 : 1;       
    }
    private void FixedUpdate()
    {
        transform.Translate(new  Vector2(Xvalue * x, Yvalue * y).normalized * Time.deltaTime * Speed);
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Hwall"))
        {
            Yvalue = Random.Range(0.1f, 1f);
            y = -y;
            //Speed += 0.1f;
        }
        if (collision.CompareTag("Vwall"))
        {
            Xvalue = Random.Range(0.1f, 1f);
            x = -x;
            //Speed += 0.1f;
        }
    }
    */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision..CompareTag("Hwall"))
        if(collision.collider.CompareTag("Hwall"))
        {
            Yvalue = Random.Range(0.1f, 1f);
            y = -y;
            //Speed += 0.1f;
        }
        if (collision.collider.CompareTag("Vwall"))
        {
            Xvalue = Random.Range(0.1f, 1f);
            x = -x;
            //Speed += 0.1f;
        }
    }
    /*
    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hwall"))
        {
            Yvalue = Random.Range(0.1f, 1f);
            y = -y;
            //Speed += 0.1f;
        }
        if (collision.CompareTag("Vwall"))
        {
            Xvalue = Random.Range(0.1f, 1f);
            x = -x;
            //Speed += 0.1f;
        }
    }
    */
}
