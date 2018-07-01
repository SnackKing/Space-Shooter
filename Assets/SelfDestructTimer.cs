using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructTimer : MonoBehaviour {

    public float destructTime = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destructTime -= Time.deltaTime;
        if(destructTime <= 0)
        {
            Destroy(gameObject);
        }
	}
}
