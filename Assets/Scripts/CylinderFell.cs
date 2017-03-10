using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderFell : MonoBehaviour {
    private Vector3 pos;
    private Quaternion rot;
    // Use this for initialization
    void Start () {
        pos = gameObject.transform.position;
        rot = gameObject.GetComponent<Rigidbody>().rotation;
        InvokeRepeating("Fell", 0.0f, 1.3f);
    }
    void Fell()
    {
        if (transform.position.y < -3)
        {
            float rand = Random.Range(-6.5f, 6.5f);
            transform.position = new Vector3(rand, 50, 70);
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().rotation = rot;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
