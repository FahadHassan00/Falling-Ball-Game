using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       // rb.velocity = new Vector2(2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void push()
    {
        rb.velocity =new Vector2(2f, 0f);
    }
}
