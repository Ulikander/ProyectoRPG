using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : Movement
{
    
    [Header("EnemyIA")]
    public string enemyID;
    public Collider2D colliderRange;
    public bool inRange;
    GameObject player;
    public enum Status { Idle, Attacking, Fleeing, Dead }
    public Status status = Status.Idle;

    public Enemy enemy;


    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckIfNull();
        inRange = (colliderRange.IsTouching(player.GetComponentInChildren<Collider2D>()));
        if (inRange && status == Status.Idle)
            status = Status.Attacking;
        if (!inRange && status == Status.Attacking)
            status = Status.Idle;

        StatusHandler();
	}

    void CheckIfNull()
    {
        if (enemy == null || enemy.nameEnemy == "")
        {
            switch (enemyID)
            {
                case "ghost":
                    enemy = Data.act.enemies[0];
                    break;
                default:
                    print("Invalid enemyID in object: " + gameObject.name);
                    break;
            }
        }
    }

    void StatusHandler()
    {
        if (status == Status.Dead)
        {
            print("ded");
            return;
        }

        

        switch (enemy.behaviour)
        {
            case Enemy.Behaviour.Melee:
                switch (status)
                {
                    case Status.Idle:
                        Move(0, 0);
                        break;
                    case Status.Attacking:
                        Vector3 move = (player.transform.position - transform.position).normalized;
                        //print("MOVE: " + move);
                        Move(move.x, move.y);
                        break;
                    case Status.Fleeing:

                        break;
                }
                break;
            case Enemy.Behaviour.Ranged:
                switch (status)
                {
                    case Status.Idle:

                        break;
                    case Status.Attacking:

                        break;
                    case Status.Fleeing:

                        break;
                }
                break;
        }
    }
}
