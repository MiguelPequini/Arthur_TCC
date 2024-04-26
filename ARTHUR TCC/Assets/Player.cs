using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;
    public bool canInteract = true;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Vector2 moveForce = playerInput * speed;
        rb.velocity = moveForce;

        anim.SetBool("Walking", playerInput != Vector2.zero);

        if (playerInput != Vector2.zero)
        {
            anim.SetFloat("Horizontal", playerInput.x);
            anim.SetFloat("Vertical", playerInput.y);
        }
        //itens
    }
}
