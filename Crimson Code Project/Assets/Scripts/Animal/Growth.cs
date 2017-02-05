using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour {

    Hunger _hunger;
    Thirst _thirst;
    int hungerLevel, thirstLevel;
    float newScale;

	// Use this for initialization
	void Start ()
    {
        _hunger = gameObject.GetComponentInChildren<Hunger>();
        _thirst = gameObject.GetComponentInChildren<Thirst>();
        hungerLevel = _hunger.hungerCount;
        thirstLevel = _thirst.thirstCount;
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        newScale = (float)(1/(hungerLevel + thirstLevel + 1))*(float)(1-gameObject.transform.localScale.x)* gameObject.transform.localScale.x;
        newScale = newScale / 5000;
        gameObject.transform.localScale += new Vector3( newScale, newScale, newScale);
	}
}
