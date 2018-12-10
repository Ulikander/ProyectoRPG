using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMovement : ZonesControl {


    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            childMap.SetActive(true);
            flagTemp = flagControl;
            flagControl = !flagControl;
            camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, camera.transform.position.z);
            //collision.transform.DetachChildren();
            //temp = collision.transform.position;
            //collision.transform.SetParent(this.transform);
            // collision.transform.position = temp;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Dentro del mapa");
            if(flagControl != flagTemp)
            {
                camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, camera.transform.position.z);
            }
        }
    }
}
