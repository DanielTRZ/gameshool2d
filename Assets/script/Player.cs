using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grouned;
    public bool doubleJump;

    //animacja//
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator> (); 
    }
    private void FixedUpdate()
    {
        grouned = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, WhatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        if (grouned)
            doubleJump = false;
        anim.SetBool("Grounded",grouned);
      /////////--jump 
        if(Input.GetKeyDown(KeyCode.Space) && grouned)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        }
        ////////-- doublejump
        if (Input.GetKeyDown(KeyCode.Space) && !grouned && !doubleJump)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
            doubleJump = true;
        }
     ////////////////////////////////////////////////////////////////--

     ///// Move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
     ///// Move Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        /////animacja
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        //obrót postaci

        //-->>> b³¹d
        if (GetComponent<Rigidbody2D>().velocity.x > 0) 
            transform.localScale = new Vector3(1f, 1f, 1f);
        

        else if (GetComponent<Rigidbody2D>().velocity.x < 0) 
            transform.localScale = new Vector3(-1f,1f,1f) ;
       
    }
  
}
