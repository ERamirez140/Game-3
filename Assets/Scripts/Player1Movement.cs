using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {
    public Rigidbody rb;
    public float speed;
    private float move;	// Use this for initialization
    private Vector3 position;
    bool up;
    bool down;
    bool left;
    bool right;
	void Start () {
        rb = GetComponent<Rigidbody>();
        //speed = 1.0f;
        move = 1.0f;
        position = rb.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
            up = false;
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
            left = false;
        if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
            down = false;
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
            right = false;
        Move();
        
        
    }
    void Move()
    {
        if (up)
            rb.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        if (down)
            rb.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        if (left)
            rb.transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        if (right)
            rb.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
    }
}
