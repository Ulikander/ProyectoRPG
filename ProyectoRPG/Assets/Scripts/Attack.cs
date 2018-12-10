using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public enum User { Enemy, Player }
    public User user;
    public enum Type { Melee, Ranged }
    public Type type;
    public double damage = 1;

    public int clipIndex;
    Animator animator;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        //animator.   
	}
	
	// Update is called once per frame
	void Update ()
    {
		switch(type)
        {
            case Type.Melee:

                break;
            case Type.Ranged:

                break;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(user == User.Player)
            if(collision.GetComponent<EnemyAI>() != null)
            {

            }

        if (user == User.Enemy)
            if (collision.GetComponent<Player>() != null)
            {

            }
    }
}
