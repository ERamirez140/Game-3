using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenMusic : MonoBehaviour {

    GameObject BackGroundMusic;
	void Start ()
    {
        GameObject BackGroundMusic = GameObject.FindGameObjectWithTag("music");
        Destroy(BackGroundMusic);
		
	}
	
	
}
