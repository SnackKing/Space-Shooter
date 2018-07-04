using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject bulletPrefab;
    float fireCooldown = 0;
    public float fireDelay;
    public int numGuns = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fireCooldown -= Time.deltaTime;
        
        if (fireCooldown <= 0)
        {
            fireCooldown = fireDelay;
            if (numGuns == 1)
            {
                Transform frontGun = transform.Find("gun");
                Instantiate(bulletPrefab, frontGun.position, new Quaternion(150, 180, 90, 0));
            }
            else if (numGuns == 2)
            {
                Transform gun1 = transform.Find("gun1");
                Transform gun2 = transform.Find("gun2");

                Instantiate(bulletPrefab, gun1.position, new Quaternion(150, 180, 90, 0));
                Instantiate(bulletPrefab, gun2.position, new Quaternion(150, 180, 90, 0));

            }
        }

       
        


    }
}
