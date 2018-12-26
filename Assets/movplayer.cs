﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplayer : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 4);

        if ((Input.GetKeyDown (moveL)) && (laneNum>1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine (stopSlide ());
            laneNum -= 1;
            controlLocked = "y";
        }

        if ((Input.GetKeyDown (moveR)) && (laneNum<3) && (controlLocked == "n"))
        {
            horizVel = 2;
            StartCoroutine (stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "lethal")
        {   
            Destroy(gameObject);
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds (.5f);
        horizVel = 0;
        controlLocked = "n";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin(Clone)")
        {
            Destroy(other.gameObject);
            GM.coinTotal += 1;
        }
    }
}
