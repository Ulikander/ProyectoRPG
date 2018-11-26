using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Movement
{
    [Header("Player")]
    public bool canMove;
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
        running = (Input.GetKey(KeyCode.Q));
        if (canMove) Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
