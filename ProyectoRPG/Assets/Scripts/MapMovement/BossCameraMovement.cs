using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCameraMovement : ZonesControl {


    public Transform top;
    public Transform right;
    public Transform left;
    public Transform bottom;

    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            //collision.transform.DetachChildren();
            //temp = collision.transform.position;
            //collision.transform.SetParent(this.transform);
            //collision.transform.position = temp;
            childMap.SetActive(true);
            flagTemp = flagControl;
            flagControl = !flagControl;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Dentro del mapa");
            if(flagControl != flagTemp)
            {
                if ((collision.transform.position.x > right.position.x || collision.transform.position.x < left.position.x) && (collision.transform.position.y > top.position.y || collision.transform.position.y < bottom.position.y))
                {
                    if (collision.transform.position.x > right.position.x && collision.transform.position.y > top.position.y)
                    {
                        camera.transform.position = new Vector3(right.position.x, top.position.y, camera.transform.position.z);
                    }
                    else if (collision.transform.position.x > left.position.x && collision.transform.position.y > top.position.y)
                    {
                        camera.transform.position = new Vector3(left.position.x, top.position.y, camera.transform.position.z);
                    }

                    else if (collision.transform.position.x > left.position.x && collision.transform.position.y > bottom.position.y)
                    {
                        camera.transform.position = new Vector3(left.position.x, bottom.position.y, camera.transform.position.z);
                    }
                    else if (collision.transform.position.x > right.position.x && collision.transform.position.y > bottom.position.y)
                    {
                        camera.transform.position = new Vector3(right.position.x, bottom.position.y, camera.transform.position.z);
                    }
                }
                else if (collision.transform.position.x > right.position.x || collision.transform.position.x < left.position.x)
                {
                    if (collision.transform.position.x > right.position.x)
                    {
                        camera.transform.position = new Vector3(right.position.x, collision.gameObject.transform.position.y, camera.transform.position.z);
                    }
                    else
                    {
                        camera.transform.position = new Vector3(left.position.x, collision.gameObject.transform.position.y, camera.transform.position.z);
                    }
                }
                else if (collision.transform.position.y > top.position.y || collision.transform.position.y < bottom.position.y)
                {
                    if (collision.transform.position.y > top.position.y)
                    {
                        camera.transform.position = new Vector3(collision.gameObject.transform.position.x, top.position.y, camera.transform.position.z);
                    }
                    else
                    {
                        camera.transform.position = new Vector3(collision.gameObject.transform.position.x, bottom.position.y, camera.transform.position.z);
                    }

                }
                else if (collision.transform.position.y < top.position.y && collision.transform.position.y > bottom.position.y && collision.transform.position.x < right.position.x && collision.transform.position.x > left.position.x)
                {
                    camera.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, camera.transform.position.z);
                }
            }
        }
    }
}
