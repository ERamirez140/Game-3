using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour {
    int fire;
    public float speed = 20;
    public GameObject cannonball;
    bool north = false;
    bool south = false;
    bool east = false;
    bool west = false;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 1.0f, 2.5f);
	}
	void resetState()
    {
        north = false;
        south = false;
        east = false;
        west = false;
    }
    private void Update()
    {
        if (east)
            cannonball.transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (west)
            cannonball.transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        if (north)
            cannonball.transform.Translate(0f,0f, speed * Time.deltaTime);
        if (south)
            cannonball.transform.Translate(0f,0f,-speed * Time.deltaTime);
    }
    // Update is called once per frame
    
	// Update is called once per frame
	void Fire () {
        if(speed < 40)
        speed *= 1.1f;
            fire = Random.Range(1, 12);
        if (fire <= 3)
            Upper(fire);
        else if (fire <= 6)
            Right(fire);
        else if (fire <= 9)
            Lower(fire);
        else
            Left(fire);
	}
    void Upper(int fire)
    {
        resetState();
        int pos = fire % 3;
        cannonball.transform.position = new Vector3(-3 + (pos * 3), 2, 20);
        south = true;
        
    }
    void Right(int fire)
    {
        resetState();
        int pos = fire % 3;
        cannonball.transform.position = new Vector3(20, 2, 3 - (pos * 3));
        west = true;
    }
    void Lower(int fire)
    {
        resetState();
        int pos = fire % 3;
        cannonball.transform.position = new Vector3(-3 + (pos * 3), 2, -20);
        north = true;
    }
    void Left(int fire)
    {
        resetState();
        int pos = fire % 3;
        cannonball.transform.position = new Vector3(-20, 2, 3 - (pos * 3));
        east = true;
    }

}
