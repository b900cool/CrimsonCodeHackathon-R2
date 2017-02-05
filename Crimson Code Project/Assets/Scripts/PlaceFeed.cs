using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceFeed : MonoBehaviour {

    public GameObject myPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 drop = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1, gameObject.transform.position.z + 1);
            GameObject go = (GameObject)Instantiate(myPrefab, drop, new Quaternion(0,0,0,0));
        }
    }
}
