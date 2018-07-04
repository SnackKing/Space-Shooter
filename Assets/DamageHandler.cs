using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

    public int health = 1;
    float invulTime = 0;
    int regLayer;
    public float invulnPeriod = 0;
   

    // Use this for initialization
    void Start () {
        regLayer = gameObject.gameObject.layer;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Trigger");
        //Debug.Log(collision);
        //Debug.Log(gameObject.name);
        //11 is the layer for environments
        if (collision.gameObject.layer != 11)
        {
            health--;
            gameObject.layer = 10;
            invulTime = invulnPeriod;
         

            if (collision.gameObject.tag == "PlayerRay" && gameObject.tag == "Enemy")
            {
                EnemyShip ship = gameObject.GetComponent<EnemyShip>();
                PlayerShip.updateScore(ship.pointValue);
            }
            else if(gameObject.tag == "Player")
            {
                PlayerShip.updateHealth(health);
            }
        }
        

    }

    // Update is called once per frame
    void Update () {
        invulTime -= Time.deltaTime;
        if(invulTime <= 0)
        {
            gameObject.layer = regLayer;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
