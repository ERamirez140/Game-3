using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal2 : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    bool won = false;
    public static bool hasBegun = false;
    public Text winText;
	// Use this for initialization
	void Awake () { 
	}
    void Begin()
    {
        winText.text = " ";
        Time.timeScale = 1;
    }
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().buildIndex == 1 && !hasBegun)
            Info2();
        if (p1.transform.position.y < -10 && !won)
        {
            won = true;
            winText.text = "BLUE WINS!!";
            //Score.blueScore += 1;
            Score.g2blue = true; 
            Invoke("nextLevel", 3.0f);
        }
        if (p2.transform.position.y < -10 && !won)
        {
            won = true;
            winText.text = "RED WINS!!";
            //Score.redScore += 1;
            Score.g2red = true;
            Invoke("nextLevel", 3.0f);
        }
    }
    void nextLevel()
    {
        if ((Score.g1red && Score.g2red && Score.g3red && Score.g4red) || (Score.g1blue && Score.g2blue && Score.g3blue && Score.g4blue))
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(3);
    }
    void Info2()
    {
        hasBegun = true;
        Time.timeScale = 0.0001f;
        winText.text = "DONT FALL OFF THE PLATFORM!";
        Invoke("Begin", 0.0003f);
    }
}
