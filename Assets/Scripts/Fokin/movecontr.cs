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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.childCount == 0)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f);
                foreach (Collider2D collider in colliders)
                {
                    if (collider.CompareTag("Item") && ((1 << collider.gameObject.layer) & pickupLayer) != 0)
                    {
                        collider.transform.parent = transform;
                        collider.GetComponent<Rigidbody2D>().isKinematic = true;
                        break;
                    }
                }
            }
            else
            {
                Transform item = transform.GetChild(0);
                item.parent = null;
                item.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}