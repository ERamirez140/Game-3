using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalScored : MonoBehaviour {
    public Text scoreBoard;
    public Text winText;
    bool scored = false;
    void Start()
    {
        winText.text = " ";        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Goal")
        {
            if(transform.position.x > 5 && !scored)
            {
                winText.text = "GOALLLLL!!!\n RED WINS!";
                //Score.redScore++;
                Score.g3red = true;
            }
            else if(transform.position.x < -5 && !scored)
            {
                winText.text = "GOALLLLL!!!\n BLUE WINS!";
                //Score.blueScore++;
                Score.g3blue = true;
            }
            Invoke("Clear", 2.0f);
        }
    }
    void Clear()
    {
        winText.text = " ";
        scored = false;
        if ((Score.g1red && Score.g2red && Score.g3red && Score.g4red) || (Score.g1blue && Score.g2blue && Score.g3blue && Score.g4blue))
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(4);
    }
}
