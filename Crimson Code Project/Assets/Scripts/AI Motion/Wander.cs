using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

    public Vector3 destination = new Vector3(1, 1, 1);
    public float speed = 1;
    public float waitTime = 3f;
    public int lowerX = -20, upperX = 20, lowerY = -20, upperY = 20;
    FollowFeed _found;

    // Use this for initialization
    void Start ()
    {
        destination = transform.position;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        _found = gameObject.GetComponentInChildren<FollowFeed>();

        float step = speed * Time.deltaTime;
        
        move(step);

        
	}

    void move(float step)
    {
        if (transform.position == destination)
        {
            
            StartCoroutine(wait());

        }
        Debug.Log(_found.sustananceDetected);
        if (_found.sustananceDetected)
        {
            transform.position = Vector3.MoveTowards(transform.position, _found.feedVector, step);
            transform.LookAt(_found.feedVector);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, step);
            transform.LookAt(destination);
        }
    }

    
    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (transform.position == destination)
        {
            destination = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
            transform.LookAt(destination);
        }
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Feed")
        {
            Destroy(other.gameObject);
            _found.sustananceDetected = false;
        }
        
    }

}
