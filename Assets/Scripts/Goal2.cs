using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal2 : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    bool won = false;
    static bool hasBegun = false;
    public Text winText;
	// Use this for initialization
	void Awake () { 
	}
    void Info()
    {
        Debug.Log("Info has been called");
        hasBegun = true;
        Time.timeScale = 0.0001f;
        winText.text = "DONT FALL OFF THE PLATFORM!";
        Invoke("Begin", 0.0003f);
    }
	void Begin()
    {
        Time.timeScale = 1;
        winText.text = " ";
    }
	// Update is called once per frame
	void Update () {
        if (!hasBegun && SceneManager.GetActiveScene().buildIndex == 1)
            Info();
        if (p1.transform.position.y < -10 && !won)
        {
            won = true;
            winText.text = "BLUE WINS!!";
            Score.blueScore += 1;
            Invoke("nextLevel", 3.0f);
        }
        if (p2.transform.position.y < -10 && !won)
        {
            won = true;
            winText.text = "RED WINS!!";
            Score.redScore += 1;
            Invoke("nextLevel", 3.0f);
        }
    }
    void nextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
