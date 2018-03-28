﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMover : MonoBehaviour {
    public float maxDistFromX = 1.5f;
    public float maxDistFromY = 1.5f;
    public GameObject playerHand;
    // Use this for initialization
    void Start ()
    {
         playerHand = GameObject.FindGameObjectWithTag("PlayerHand");
    }
	
	void FixedUpdate () {
        if (transform.position.x > playerHand.transform.position.x + maxDistFromX)
        {
            transform.position = new Vector3(playerHand.transform.position.x + maxDistFromX, transform.position.y, transform.position.z);
        }

        if (transform.position.x < playerHand.transform.position.x - maxDistFromX)
        {
            transform.position = new Vector3(playerHand.transform.position.x - maxDistFromX, transform.position.y, transform.position.z);
        }

        if (transform.position.y > playerHand.transform.position.y + maxDistFromY)
        {
            transform.position = new Vector3(transform.position.x, playerHand.transform.position.y + maxDistFromY, transform.position.z);
        }

        if (transform.position.y < playerHand.transform.position.y - maxDistFromY)
        {
            transform.position = new Vector3(transform.position.x, playerHand.transform.position.y - maxDistFromY, transform.position.z);
        }
		
    }
}
