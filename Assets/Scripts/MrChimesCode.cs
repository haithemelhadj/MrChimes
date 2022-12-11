using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrChimesCode : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float mvnt;
    public float x, y;
    

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, 2) == 0 ? -1 : 1;
        y = Random.Range(0, 2) == 0 ? -1 : 1;
        //rb.velocity = new Vector2(speed * x, speed * y);

        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector2(speed * x, speed * y) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Vwall")
        {
            x = -x;
            x = Random.Range(0, -x);// == 0 ? -1 : 1;
            //rb.velocity = new Vector2(speed * x, speed * y);

        }
        else if (collision.gameObject.tag == "Hwall")
        {
            y = -y;
            y = Random.Range(0, -y);// == 0 ? -1 : 1;
            //rb.velocity = new Vector2(speed * x, speed * y);
        }

    }
}
