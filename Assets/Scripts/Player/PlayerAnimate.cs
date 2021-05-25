using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerMovements))]
public class PlayerAnimate : MonoBehaviour
{
    public float walkDelta;
    Animator animator;
    SpriteRenderer spriteRenderer;
    PlayerMovements playerMovements;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMovements = GetComponent<PlayerMovements>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = playerMovements.moveInputs.magnitude > walkDelta;
        animator.SetBool("IsWalking", false);
        animator.SetFloat("MoveX", playerMovements.moveInputs.x);
        animator.SetFloat("MoveY", playerMovements.moveInputs.y);
        spriteRenderer.flipX = playerMovements.moveInputs.x < 0;
    }
}
