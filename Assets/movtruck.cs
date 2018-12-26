using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movtruck : MonoBehaviour {

    public Transform[] obstacle;
    public int current = 0;

    public float horizVel = 0;
    public int laneNum = 1;

    // Update is called once per frame
    void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 4);

        if (((obstacle[current].position.z - transform.position.z) <= 3) && (current <= 2))
        {
            Debug.Log("Jarak " + (transform.position.z - obstacle[current].position.z));
            Debug.Log("Sekarang obs ke-" + current + ". Posisinya z -nya " + obstacle[current].position.z);
            if (laneNum==1)
            {
                Debug.Log("Dari " + laneNum);
                horizVel = 2;
                StartCoroutine(stopSlide());
                laneNum += 1;
                current += 1;
                Debug.Log("Ke " + laneNum);
            }

            else if (laneNum==2)
            {
                Debug.Log("Dari " + laneNum);
                horizVel = 2;
                StartCoroutine(stopSlide());
                laneNum += 1;
                current += 1;
                Debug.Log("Ke " + laneNum);
            }

            else if (laneNum==3)
            {
                Debug.Log("Dari " + laneNum);
                horizVel = -2;
                StartCoroutine(stopSlide());
                laneNum -= 1;
                current += 1;
                Debug.Log("Ke " + laneNum);
            }
        } else{}
            
	}

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
    }
}
