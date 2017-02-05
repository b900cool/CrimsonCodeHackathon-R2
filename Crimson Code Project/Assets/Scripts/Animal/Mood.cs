using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mood: Pet
    {
    public enum feeling
    {
        Sad, Happy, Hungry, Thirsty, Full, Angry, Scared
    };
    public void setMood(feeling feel)
    {
        curMood = feel;
    }

    public feeling getMood()
    {
        return curMood;
    }
    public feeling curMood;

	// Use this for initialization
	void Start()
    {	
	}
	
	// Update is called once per frame
	void Update()
    {
	}
}
