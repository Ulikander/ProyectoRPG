using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Movement
{
    public Transform[] waypoints;
    int waypointIndex = 0;
    // Use this for initialization

    void Start()
    {
        transform.position = waypoints[waypointIndex].position;
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        if (canMove)
            WaypointMove();
        else
            Move(0, 0);
    }

    void WaypointMove()
    {
        Vector3 move = (waypoints[waypointIndex].position - transform.position).normalized;
        Move(move.x, move.y);
        if (Vector3.Distance(transform.position, waypoints[waypointIndex].position) < 0.15f)
        {
            if (waypointIndex + 1 == waypoints.Length)
                waypointIndex = 0;
            else
                waypointIndex++;
        }
    }
}
