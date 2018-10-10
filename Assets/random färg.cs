using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomfärg : MonoBehaviour {
    
    public float color1;
    public float color2;
    
    public Color ship;
    public SpriteRenderer shipcolor;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //när du trycker på space så får skeppet en random färg
        if (Input.GetKey(KeyCode.Space))
        {
            ship = new Color(Random.Range(0f,2f),Random.Range(0f,2f),Random.Range(0f,2f));
            shipcolor.color = ship;
                
            
        }
    }

}
