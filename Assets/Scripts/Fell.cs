using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fell : MonoBehaviour {
    private Vector3 pos;
    private Quaternion rot;
    // Use this for initialization
    void Start () {
        pos = gameObject.transform.position;
        rot = gameObject.GetComponent<Rigidbody>().rotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if ((gameObject.transform.position.y < -5 && gameObject.tag != "Cylinder") || (gameObject.tag == "Cylinder" && gameObject.transform.position.y < 2))
        {
            resetPost();
        }

	}
    void resetPost()
    {
        gameObject.transform.position = pos;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().rotation = rot;
    }
}
