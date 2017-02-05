using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personality: MonoBehaviour
{
    enum personality
    {
        Timid, Social, Asshole, Cunt
    };
	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        personality character;

        character = (personality)Random.Range(0, 3);	
	}
}
