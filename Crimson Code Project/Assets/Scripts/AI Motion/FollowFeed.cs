using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFeed : MonoBehaviour {

    public bool feedDetected = false;
    public Vector3 feedVector;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Feed")
        { 
            feedDetected = true;
            Debug.Log("FeedDetected");
            feedVector = new Vector3(other.transform.position.x, 0.5f, other.transform.position.z);
        }
        
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Feed")
        {
            feedDetected = false;
        }
        Debug.Log("FeedLost");
    }
}
