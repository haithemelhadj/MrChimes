using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrChimesCode : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 3f;
    public Vector2 movement;
    //get screen dimensions
    private Vector2 screenBounds;
    

    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector2(-1f, -0.5f);
        //get screen dimensions
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(movement * speed * Time.deltaTime);
        if (transform.position.x < -screenBounds.x + 0.5f)
        {
            movement *= new Vector2(-1f, 1f);
        }
        if (transform.position.x > screenBounds.x  -0.5f)
        {
            movement *= new Vector2(-1f, 1f);
        }
        if (transform.position.x < -screenBounds.y + 0.5f)
        {
            movement *= new Vector2(-1f, 1f);
        }

        if (transform.position.x > screenBounds.y * -0.5f)
        {
            movement *= new Vector2(1f, -1f);
        }
    }
}
