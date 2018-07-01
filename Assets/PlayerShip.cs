using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public float speed = 6;
    public float fireCoolDown = 0.25f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Horizontal");
        float xAxis = Input.GetAxis("Vertical");
        float currentLeftBound = GameObject.Find("Main Camera").GetComponent<PlayerShipCamera>().currentLeftBound;
        float currentRightBound = GameObject.Find("Main Camera").GetComponent<PlayerShipCamera>().currentRightBound;

        Vector3 newPos = new Vector3(transform.position.x, transform.position.y);
        //top left corner
        if(transform.position.x <= currentLeftBound && transform.position.y >= 8)
        {
            Debug.Log("top left corner");
            newPos.y = 7.9999f;
            newPos.x = currentLeftBound + 0.01f;
            transform.position = newPos;

        }
        else if(transform.position.x <= currentLeftBound && transform.position.y <= - 8)
        {
            Debug.Log("Bottom left corner");
            newPos.y = -7.9999f;
            Debug.Log("new vector is " + newPos);
            transform.position = newPos;
        }
        else if(transform.position.x >= currentRightBound && transform.position.y >= 8)
        {
            Debug.Log("Top right corner");
            newPos.y = 7.9999f;
            newPos.x = currentRightBound - 0.01f;
            Debug.Log("new vector is " + newPos);
            transform.position = newPos;
        }
        else if (transform.position.x >= currentRightBound && transform.position.y <=  -8)
        {
            Debug.Log("Bottom right corner");
            newPos.y = -7.9999f;
            newPos.x = currentRightBound - 0.01f;
            Debug.Log("new vector is " + newPos);
            transform.position = newPos;
        }
        else if (transform.position.y >= 8)
        {
            Debug.Log("Too high");
            newPos.y = 7.9999f;
            Debug.Log("new vector is " + newPos);
            transform.position = newPos;
        }
        else if (transform.position.y <= -8)
        {
            newPos.y = -7.9999f;
            transform.position = newPos;
            Debug.Log("Bottom");

        }
        else if (transform.position.x <= currentLeftBound)
        {
            newPos.x = currentLeftBound + 0.05f;
            transform.position = newPos;
            Debug.Log("Too far left");

        }
        else if (transform.position.x >= currentRightBound)
        {
            newPos.x = currentRightBound - 0.01f;
            transform.position = newPos;
            Debug.Log("Too far right");
        }
        else
        {
            newPos = new Vector3(xAxis, yAxis) * Time.deltaTime * speed;
            transform.Translate(newPos);


        }



    }
}
