using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int redScore = 0;
    public static int blueScore = 0;
    public static Text scoreBoard;
    public static Text winText;
    private static Score instance;
    // Use this for initialization
    void Awake()
    {
        //scoreBoard.text = " ";
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        //scoreBoard.text = "SCORE\nRed: " + redScore + "\nBlue: " + blueScore;
    }
}
