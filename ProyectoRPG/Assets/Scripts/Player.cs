using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Movement
{
    [Header("Player")]
    public StandardAnimation animations;
    public bool forceAnimated;
    public Character character;

    // Use this for initialization
    void Start()
    {
        character = Data.act.characters[0];
	}
	
	// Update is called once per frame
	public override void Update ()
    {
        base.Update();
        InputAttackHandler();
        InputMovementHandler();
        AnimationCtrl();
	}

    private void InputAttackHandler()
    {
        if (attacking) return;
        if (Input.GetKeyDown(KeyCode.W)) Attack();
        if (Input.GetKeyDown(KeyCode.R)) Skill();
        if (Input.GetKeyDown(KeyCode.Space)) Defend();
    }

    void InputMovementHandler()
    {
        running = (Input.GetKey(KeyCode.Q) && !attacking);

        if (!canMove) return;

        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void AnimationCtrl()
    {
        if (forceAnimated)
            animations.playing = true;
        else if (Mathf.Abs(rb.velocity.x) < 0.1f && Mathf.Abs(rb.velocity.y) < 0.1f)
        {
            animations.playing = false;
        }
        else
        {
            animations.playing = true;
        }

        //0 -> DOWN | 1 -> LEFT | 2 -> RIGHT| 3 -> UP
        if (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKeyDown(KeyCode.DownArrow) && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))))
        {
            animations.lookingAt = 0;
            return;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.UpArrow) && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))))
        {
            animations.lookingAt = 3;
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animations.lookingAt = 1;
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animations.lookingAt = 2;
            return;
        }
    }
}
