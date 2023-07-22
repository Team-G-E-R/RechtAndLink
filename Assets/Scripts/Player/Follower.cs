using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform mainCharTransform; 
    public float speed = 2.0f;  
    public float stoppingDistanceHorizontal = 1.0f; 
    public float stoppingDistanceVertical = 1.0f; 
    public Animator anim; 
    void Update()
    {
        if (mainCharTransform == null)
        {

            GameObject mainChar = GameObject.FindGameObjectWithTag("MainChar");
            if (mainChar != null)
            {
                mainCharTransform = mainChar.transform;
            }
            else
            {
    
                return;
            }
        }


        float distanceHorizontal = mainCharTransform.position.x - transform.position.x;
        float distanceVertical = mainCharTransform.position.y - transform.position.y;


        if (Mathf.Abs(distanceHorizontal) > stoppingDistanceHorizontal || Mathf.Abs(distanceVertical) > stoppingDistanceVertical)
        {
  
            Vector2 direction = mainCharTransform.position - transform.position;
            direction.Normalize();


            transform.position += (Vector3)direction * speed * Time.deltaTime;


            float xMove = direction.x;
            float yMove = direction.y;
            anim.SetFloat("Horizontal", xMove);
            anim.SetFloat("Vertical", yMove);
            anim.SetFloat("Speed", speed);
        }
        else
        {
            anim.SetFloat("Speed", 0f);
        }
    }
}