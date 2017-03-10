using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour {
    int direction;
    public int force;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.tag == "PlayerOne")
            direction = 1;
        if (c.gameObject.tag == "Player2")
            direction = -1;
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(direction, 0, 0) * force);            
    }
}
