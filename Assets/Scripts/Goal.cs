using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Goal : MonoBehaviour {
    public Text winnerText;
    bool hasWon = false;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0.0001f;
        winnerText.text = "RACE TO THE TOP!";
        Invoke("Begin", 0.0003f);
	}
    void Begin()
    {
        Time.timeScale = 1;
        winnerText.text = " ";
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision c)
    {
        if (!hasWon)
        {
            if (c.gameObject.tag == "PlayerOne")
            {
                hasWon = true;
                winnerText.text = "RED WINS!!";
                //Score.redScore += 1;
                Score.g1red = true;
                Invoke("callRestart", 3.0f);
            }
            if (c.gameObject.tag == "PlayerTwo")
            {
                hasWon = true;
                winnerText.text = "BLUE WINS!!";
                //Score.blueScore += 1;
                Score.g1blue = true;
                Invoke("callRestart", 3.0f);
            }
        }
    }
    void callRestart()
    {
        winnerText.text = " ";
        if ((Score.g1red && Score.g2red && Score.g3red && Score.g4red) || (Score.g1blue && Score.g2blue && Score.g3blue && Score.g4blue))
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(2);
    }

}
