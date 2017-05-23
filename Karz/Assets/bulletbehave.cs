using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbehave : MonoBehaviour {
    public GameObject CarWaypointBased;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        transform.position += transform.forward;
    }
    private void OnCollisionEnter(Collision collidedObjext)
    {
        if(collidedObjext.gameObject.tag == "Enemy")
        {
            print(collidedObjext.gameObject.name);
            print(collidedObjext.transform.position);
            Destroy(collidedObjext.gameObject);
            Instantiate(CarWaypointBased, new Vector3(235, 10, 394), Quaternion.identity);
        }
        
    }
}
