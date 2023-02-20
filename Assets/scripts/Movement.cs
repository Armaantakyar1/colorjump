using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    Rigidbody2D rb;
    [SerializeField]float jumpForce = 2f;
    [SerializeField] KeyCode right;
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode jump;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {

        float horizontal = 0;
       

        if (Input.GetKey(right))
        {
            horizontal = 1f;
        }
        if (Input.GetKey(left))
        {
            horizontal = -1f;
        }
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }


        Vector2 direction = new Vector2(horizontal,0);
        rb.velocity = direction * speed;

    }
}
