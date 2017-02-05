using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirst: MonoBehaviour
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
        
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                thirstCount++;
                timer = 0.0f;
            }
            if (thirstCount > 100)
                thirstCount = 100;
            if (thirstCount < 0)
                thirstCount = 0;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            thirstCount -= 15;

        }

    }
}
