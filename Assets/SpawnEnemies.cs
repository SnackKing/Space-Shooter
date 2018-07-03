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
        if(other.gameObject.name == "PlayerShip")
        {
            Vector3 position = transform.position;
            position.x = position.x + 20;
            for (int i = 0; i < numEnemies; i++)
            {
                position.y += 1.5f;
                Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);
            }

        }
    }

    // Update is called once per frame
    void Update () {
       
		
	}
}
