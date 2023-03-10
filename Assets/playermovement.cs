using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Animator animator;

    public Rigidbody2D rb;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position+movement*moveSpeed*Time.fixedDeltaTime);
    }
}
