using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private float move;	// Use this for initialization
    private Vector3 position;
    bool up;
    bool down;
    bool left;
    bool right;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //speed = 1.0f;
        move = 1.0f;
        position = rb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
            up = false;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            left = false;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
            down = false;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
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
