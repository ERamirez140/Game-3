using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class LimitMove : MonoBehaviour {
    public float upperLimit = 3f;
    public float lowerLimit = -3f;
    public Rigidbody rb;
    public float speed;
    bool up;
    bool down;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
            up = false;
        if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
            down = false;
        Move();
    }
    void Move()
    {
        if (up && rb.transform.position.z < upperLimit)
            rb.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        if (down && rb.transform.position.z > lowerLimit)
            rb.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
    }
}
