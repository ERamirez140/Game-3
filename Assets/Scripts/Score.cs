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
    public static bool g1red = false, g1blue = false;
    public static bool g2red = false, g2blue = false;
    public static bool g3red = false, g3blue = false;
    public static bool g4red = false, g4blue = false;

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
