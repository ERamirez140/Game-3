using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3 : MonoBehaviour {
    public Text scoreboard;
    string r1, b1, r2, b2, r3, b3, r4, b4;
    // Use this for initialization
    void Awake()
    {
        scoreboard.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.g1red == false) r1 = "O"; else r1 = "X";
        if (Score.g2red == false) r2 = "O"; else r2 = "X";
        if (Score.g3red == false) r3 = "O"; else r3 = "X";
        if (Score.g4red == false) r4 = "O"; else r4 = "X";
        if (Score.g1blue == false) b1 = "O"; else b1 = "X";
        if (Score.g2blue == false) b2 = "O"; else b2 = "X";
        if (Score.g3blue == false) b3 = "O"; else b3 = "X";
        if (Score.g4blue == false) b4 = "O"; else b4 = "X";
        scoreboard.text =
            "\n\tLEADERBOARD\n" +
            "\t\tRED | BLUE\n" +
            "\tG1\t" + r1 + "  |  " + b1 +
            "\n\tG2\t" + r2 + "  |  " + b2 +
            "\n\tG3\t" + r3 + "  |  " + b3 +
             "\n\tG4\t" + r4 + "  |  " + b4;
    }
}
