using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   //den här gör så att tiden visas i consolen varje sekund
public class timer : MonoBehaviour {
    public float TimeHasPassed;

	
	void Start () {
        InvokeRepeating("Timer", 1f, 1f);
	}
	
	
	void Update () {
        
	}
    void Timer()
    {
        TimeHasPassed += 1;
        Debug.Log(string.Format("Timer{0}", TimeHasPassed));
        
    }
}
