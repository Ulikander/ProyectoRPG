using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    [Header("Movement")]
    public float movSpeed;
    public float movRunningSpeed;
    public bool running;
    public bool canMove;
    public bool attacking;

    // Use this for initialization
    void Awake ()
    {
        rb = GetComponent<Rigidbody2D>();
	}

    public virtual void Update()
    {
        SpritePriority();
    }

    public void Move(float inputX, float inputY)
    {
        float speed = movSpeed;
        if (running) speed = movRunningSpeed;

        float movX = inputX * speed;
        float movY = inputY * speed;
        rb.velocity = new Vector2(movX, movY);
    }

    public void SpritePriority()
    {
        if (sr == null) return;
        sr.sortingOrder = -(int)(transform.position.y * 100);
    }

    public void Attack()
    {
        print("Atacó");
    }

    public void Defend()
    {
        print("Defendió");
    }

    public void Skill()
    {
        print("Usó Skill");
    }

}
