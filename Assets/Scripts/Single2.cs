using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Single2 : MonoBehaviour {


    private static Single2 instance;
    // Use this for initialization
    void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
