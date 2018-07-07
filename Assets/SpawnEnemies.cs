using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    public GameObject enemyPrefab;
    public GameObject gunshipPrefab;

    private int numEnemies = 0;
    public int numShips = 0;
    public int numGunships = 0;
    private bool active = true;
	// Use this for initialization
	void Start () {
        numEnemies = numShips + numGunships;
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "PlayerShip" && active)
        {
            active = false;
            Vector3 position = transform.position;
            position.x = position.x + 20;
            for (int i = 0; i < numShips; i++)
            {
                position.y = getRandomDistanceDif();
                Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);
            }
            for (int i = 0; i < numGunships; i++)
            {
                position.y = getRandomDistanceDif();
                Instantiate(gunshipPrefab, position, enemyPrefab.transform.rotation);
            }

        }
    }

    // Update is called once per frame
    void Update () {
       
		
	}
    float getRandomDistanceDif()
    {
        return Random.Range(-6f, 6f);
    }
}
