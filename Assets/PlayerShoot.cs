using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject bulletPrefab;
    
    float fireCooldown = 0;
    public float fireDelay;
    private PlayerShip player;
    
	// Use this for initialization
    void Awake()
    {
        player = GetComponent<PlayerShip>();
        fireDelay = player.fireCoolDown;
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fireCooldown -= Time.deltaTime;
        //GetButton allows button to be held down (instead of GetButtonDown)
        if (Input.GetButton("Fire1") && fireCooldown < 0)
        {
            fireCooldown = fireDelay;
            Transform frontGun = transform.Find("frontGun");
            Instantiate(bulletPrefab, frontGun.position, new Quaternion(0, 180, 90,0));
        }
		
	}
}
