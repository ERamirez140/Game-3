using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class LimitMove2 : MonoBehaviour {
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
            up = false;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
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
