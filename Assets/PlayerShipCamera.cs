using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipCamera : MonoBehaviour {
    private float speed = 5;
    public float currentLeftBound = -20;
    public float currentRightBound = 22;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        currentLeftBound += 0.03f;
        currentRightBound += 0.03f;
        transform.Translate(0.03f, 0, 0);
    }
    float getCurrentLeftBound()
    {
        return currentLeftBound;
    }
}
