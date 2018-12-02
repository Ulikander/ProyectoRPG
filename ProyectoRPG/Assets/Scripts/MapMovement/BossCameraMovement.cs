using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCameraMovement : MonoBehaviour {

    public GameObject childMap;
    public GameObject camera;

    void Start()
    {
        childMap = this.gameObject.transform.GetChild(0).gameObject;
        camera = GameObject.Find("Main Camera");
        childMap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Salio");
            childMap.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Dentro del mapa");
            childMap.SetActive(true);
            camera.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, camera.transform.position.z);
        }
    }
}
