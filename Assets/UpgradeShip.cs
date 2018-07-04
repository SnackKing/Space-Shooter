using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShip : MonoBehaviour {
    public string type = "damage";
    public int cost = 2;
    bool active = true;

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(PlayerShip.score <= cost)
            {
                //Player has insufficient points
                Debug.Log("Not enough points");
            }
            else
            {
                Debug.Log("Upgrade acquired");
                PlayerShip.updateScore(-cost);
                PlayerShip.damage++;
                active = false;
            }
        }
    }
   
    // Update is called once per frame
    void Update () {
		
	}
}
