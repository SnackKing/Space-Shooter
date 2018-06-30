using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject bulletPrefab;
    float fireCooldown = 0;
    public float fireDelay;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fireCooldown -= Time.deltaTime;
        
        if (fireCooldown <= 0)
        {
            fireCooldown = fireDelay;
            Transform frontGun = transform.Find("gun");
            Instantiate(bulletPrefab, frontGun.position, new Quaternion(150, 180, 90, 0));
        }

       
        


    }
}
