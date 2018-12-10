using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesControl : MonoBehaviour {

    public GameObject childMap;
    public GameObject camera;
    public Vector3 temp;
    public static bool flagControl = false;
    public static bool flagTemp;

    public virtual void Start () {
        childMap = gameObject.transform.GetChild(0).gameObject;
        camera = GameObject.Find("Main Camera");
        childMap.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    public void OnTriggerEnter2D(Collider2D collision)
    {

    }
    */
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Salio");
            childMap.SetActive(false);
            
        }
    }
    /*
    public void OnTriggerStay2D(Collider2D collision)
    {

    }
    */
}
