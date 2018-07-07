using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShip : MonoBehaviour {
    public string type = "damage";
    public int cost = 2;
    bool active = true;
    float timer = 5f;
    public Text infoText;

    // Use this for initialization
    void Start () {
        Vector3 shipPos = transform.position;
        shipPos.y += 10;
        Debug.Log(shipPos);
        infoText = GameObject.Find(gameObject.name + "/WorldCanvas/upgradeText").GetComponent<Text>();
       // infoText.transform.position = shipPos;
        RectTransform rt = infoText.GetComponent<RectTransform>();
        rt.anchoredPosition = shipPos;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(PlayerShip.score <= cost)
            {
                //Player has insufficient points
                infoText.text = "Not enough points";
              
            }
            else
            {
                Debug.Log("Upgrade acquired");
                PlayerShip.updateScore(-cost);
                PlayerShip.damage++;
                infoText.text = "Damage Upgraded";
                active = false;
            }
        }
    }
   
    // Update is called once per frame
    void Update () {
		
	}
}
