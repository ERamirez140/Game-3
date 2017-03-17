using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tag : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public Text winText;
    public static bool winner = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<Renderer>().material.color != collision.gameObject.GetComponent<Renderer>().material.color)
        {
            if (collision.gameObject.tag == "PlayerOne" && !winner)
            {
                winner = true;
                winText.text = "Blue Wins!";
                Score.g4blue = true;
                Invoke("Next", 2.0f);
            }
        else if (collision.gameObject.tag == "PlayerTwo" && !winner)
            {
                winner = true;
                winText.text = "Red Wins!";
                Score.g4red = true;
                Invoke("Next", 2.0f);
            }
        }
    }
    void Next()
    {
        if ((Score.g1red && Score.g2red && Score.g3red && Score.g4red) || (Score.g1blue && Score.g2blue && Score.g3blue && Score.g4blue))
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(1);
        winner = false;
    }
}
