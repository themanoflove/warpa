using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {
    public float TimeHasPassed;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Timer", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void Timer()
    {
        TimeHasPassed += 1;
        Debug.Log(string.Format("Timer{0}", TimeHasPassed));
        
    }
}
