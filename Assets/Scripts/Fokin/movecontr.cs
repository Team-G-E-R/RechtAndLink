using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontr : MonoBehaviour

{
    [SerializeField] float speed;
    [SerializeField] Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2 (xMove * speed, yMove * speed).normalized * speed;
    }

}
