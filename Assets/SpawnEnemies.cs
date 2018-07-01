using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    public GameObject enemyPrefab;
    public int numEnemies;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered by " + other.gameObject.name);
        if(other.gameObject.name == "PlayerShip")
        {
            Debug.Log("Spawn");
            Vector3 position = transform.position;
            position.x = position.x + 20;
            for (int i = 0; i < numEnemies; i++)
            {
                position.y += 1.5f;
                Instantiate(enemyPrefab, position, new Quaternion(150, 180, 90, 0));
            }

        }
    }

    // Update is called once per frame
    void Update () {
       
		
	}
}
