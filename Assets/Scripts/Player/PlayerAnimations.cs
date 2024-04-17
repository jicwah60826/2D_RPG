using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAnimations : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash(name: "MoveX");
    private readonly int moveY = Animator.StringToHash(name: "MoveY");
    private readonly int moving = Animator.StringToHash(name: "Moving");
    private readonly int dead = Animator.StringToHash(name: "Dead");

    private Animator animator;

    private void Awake()
    {

        animator = GetComponent<Animator>();
    }

    public void ShowDeadAnimation()
    {
        animator.SetTrigger(dead);
    }

    public void SetMoveBoolTransition(bool value)
    {
        animator.SetBool(moving, value);
        animator.SetBool(moving, value);
        animator.SetBool(moving, value);
    }

    public void SetMoveAnimation(Vector2 dir)
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}
