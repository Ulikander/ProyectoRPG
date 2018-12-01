using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerBoyMovement : MonoBehaviour {

    public float moveSpeed;
    public bool isWalking;
    public float walkTime;
    public float waitTime;
    public Collider2D walkZone;

    private Rigidbody2D rb2d;
    private float walkCounter;
    private float waitCounter;
    private int walkDirection;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    private bool hasWalkZone;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min; //tomamos los valores minimos de los limites de nuestra walk zone
            maxWalkPoint = walkZone.bounds.max; //Lo mismo pero con los mayores
            hasWalkZone = true;
        }

        

	}

    // Update is called once per frame
    void Update () {
        WalkingAction();
        //Si colisiona con pared u obstaculo reiniciar direccion a la que caminara
    }

    public void WalkingAction()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (walkDirection)
            {
                case 0:
                    
                    if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        rb2d.velocity = new Vector2(0, -moveSpeed);
                        //isWalking = false;
                        //waitCounter = waitTime;//Aqui lo detenemos si nuestro player va mas alla de los limites de de arriba    
                    }
                    else
                    {
                        rb2d.velocity = new Vector2(0, moveSpeed);
                    }
                    break;
                case 1:
                    
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        rb2d.velocity = new Vector2(-moveSpeed, 0);
                        //isWalking = false;
                        //waitCounter = waitTime;//Aqui lo detenemos si nuestro player va mas alla de los limites de la derecha
                    }
                    else
                    {
                        rb2d.velocity = new Vector2(moveSpeed, 0);
                    }
                    break;
                case 2:
                    
                    if (hasWalkZone && transform.position.y < maxWalkPoint.y)
                    {
                        rb2d.velocity = new Vector2(0, moveSpeed);
                        //isWalking = false;
                        //waitCounter = waitTime;//Aqui lo detenemos si nuestro player va mas alla de los limites de Abajo
                    }
                    else
                    {
                        rb2d.velocity = new Vector2(0, -moveSpeed);
                    }
                    break;
                case 3:
                    
                    if (hasWalkZone && transform.position.x < maxWalkPoint.x)
                    {
                        rb2d.velocity = new Vector2(moveSpeed, 0);
                        //isWalking = false;
                        // waitCounter = waitTime;//Aqui lo detenemos si nuestro player va mas alla de los limites de la izquierda
                    }
                    else
                    {
                        rb2d.velocity = new Vector2(-moveSpeed, 0);
                    }
                    break;

            }
            if (walkCounter < 0)
            {
                isWalking = false;
                walkCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;

            rb2d.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
