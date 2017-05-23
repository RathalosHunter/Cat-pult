using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

    bool isPressed0;
    bool isPresses1;
    public GameObject bulletPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isPressed0 = Input.GetKey(KeyCode.Mouse0);
        isPresses1 = Input.GetKeyDown(KeyCode.Mouse1);
	}
    void FixedUpdate()
    {
        if(isPressed0 == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
        if(isPresses1 == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
