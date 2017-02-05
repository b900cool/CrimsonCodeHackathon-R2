using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

    public Vector3 destination = new Vector3(1, 1, 1);
    public float speed = 1;
    public float waitTime = 3f;
    public int lowerX = -20, upperX = 20, lowerY = -20, upperY = 20;

    // Use this for initialization
    void Start ()
    {
        destination = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float step = speed * Time.deltaTime;
        
        move(step);

        
	}

    void move(float step)
    {
        if (transform.position == destination)
        {
            
            StartCoroutine(wait());

        }

        transform.position = Vector3.MoveTowards(transform.position, destination, step);
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

    void OnTriggerEnter(Collider col)
    {

    }

}
