using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirst: Pet
{
    public int thirstCount = 0;
    private float timer = 0.0f;
	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        while (true)
        {
            timer += Time.deltaTime;
            if (timer >= 10)
            {
                thirstCount++;
                timer = 0.0f;
            }
        }
    }
}
