using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {
    public float maxSpeed = 10;
    public bool isMovingRight = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);
        if (isMovingRight)
        {
        transform.position = pos + velocity;
        }
        else
        {
            transform.position = pos - velocity;
        }
	}
}
