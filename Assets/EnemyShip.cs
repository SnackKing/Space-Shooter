using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour {

    public float speed = 5f;
    public int pointValue = 1;
    public bool flipMovement = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (flipMovement)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));

        }
        else
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));

        }
    }
}
