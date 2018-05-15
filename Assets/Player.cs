using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10f;
    public float areaWidth = 3f;

    bool isIgnore = false;

    private Collision2D collision;

    public float invincibleTime = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.acceleration.x * speed;

        rb.velocity = new Vector2(x, 0);
    }

    void FixedUpdate()
    {
        //float x = Input.acceleration.x * Time.fixedDeltaTime * speed;

        //float x = Input.acceleration.x * speed;

        //float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        //Vector2 newPosition = rb.position + Vector2.right * x;

        //rb.velocity = new Vector2(x, 0);

        //newPosition.x = Mathf.Clamp(newPosition.x, -areaWidth, areaWidth);

        //rb.MovePosition(newPosition);
    }

    public void InputProximity(PAProximity.Proximity arg)
    {
        if(arg == PAProximity.Proximity.NEAR)
        {
            isIgnore = true;
            if (isIgnore)
            {
                if (collision.gameObject.tag == "Obstacle")
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                
            }
        }
        FindObjectOfType<GameManager>().EndGame();
    }
}
