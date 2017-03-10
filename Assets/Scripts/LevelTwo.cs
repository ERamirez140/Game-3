using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwo : MonoBehaviour
{

    public Text scoreboard;
    // Use this for initialization
    void Awake()
    {
        scoreboard.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        scoreboard.text = "SCORE\nRed: " + Score.redScore + "\nBlue: " + Score.blueScore;
    }
}