using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;

    private PlayerActions actions;

    private Rigidbody2D rb2D;

    private Vector2 moveDirection;

    private Animator animator;

    private readonly int moveX = Animator.StringToHash(name: "MoveX");
    private readonly int moveY = Animator.StringToHash(name: "MoveY");

    private readonly int moving = Animator.StringToHash(name: "Moving");

    private void Awake()
    {
        actions = new PlayerActions();

        rb2D = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        ReadMovement();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;

        // Update animation float params

        if (moveDirection == Vector2.zero)

        {
            animator.SetBool(moving, false);

            return;
        }

        animator.SetBool(moving, true);

        animator.SetFloat(moveX, moveDirection.x);
        animator.SetFloat(moveY, moveDirection.y);

    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}
