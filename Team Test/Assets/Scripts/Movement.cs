using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public GameObject go;
    public float speed;
    private  Rigidbody2D rb;
    private Transform my_transform;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = go.GetComponent<Rigidbody2D>();
        my_transform = go.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector2 pos = my_transform.position;
            Vector2 pos2 = target.position;

            float x_diff = pos2.x - pos.x;
            float y_diff = pos2.y - pos.y;

            if (pos2.x < pos.x)
            {
                x_diff = -1;
            }
            else 
            {
                if (pos2.x > pos.x)
                {
                    x_diff = 1;
                }
                else 
                {
                    x_diff = 0;
                }
            }

            if (pos2.y < pos.y)
            {
                y_diff = -1;
            }
            else
            {
                if (pos2.y > pos.y)
                {
                    y_diff = 1;
                }
                else
                {
                    y_diff = 0;
                }
            }

            rb.velocity = new Vector3(x_diff * speed, y_diff * speed);
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(rb.velocity.x, speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(rb.velocity.x, -speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
        }
        
    }
}
