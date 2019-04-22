using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float forwardForce = 10f;
    public float upwardForce = 30f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.right* forwardForce);
        if(Input.GetKey("space"))
        {
            rb.AddForce(transform.up * upwardForce);
        }
    }
}
