using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontr : MonoBehaviour
{
    public LayerMask pickupLayer;
    public float speed = 1f;
    public Animator anim;
    Vector2 direction;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xMove * speed, yMove * speed);
        direction = new Vector2(xMove, yMove).normalized;
        anim.SetFloat("Horizontal", xMove);
        anim.SetFloat("Vertical", yMove);
        anim.SetFloat("Speed", direction.magnitude);
    }
}