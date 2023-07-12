using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontr : MonoBehaviour

{
    public float speed = 1f;
    public Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2 (xMove * speed, yMove * speed);
    }

}
