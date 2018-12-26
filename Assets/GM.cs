using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public static float coinTotal = 0;
    public static float timeTotal = 0;

    public static float zScenePos = 20;

    public Transform NoPit;
    public Transform RightPit;
    public Transform LeftPit;
    public Transform MidPit;

    public Transform Coin;
    public Transform Obstacle1;
    public Transform Obstacle2;
    public Transform Obstacle3;

    public movtruck movtruckscript;

    int randomNumber;

	// Use this for initialization
	void Start () {
        //

    }
	
	// Update is called once per frame
	void Update () {
		if (zScenePos < 1200)
        {
            randomNumber = Random.Range(0, 12);

            if (randomNumber < 4)
            {
                randomNumber = Random.Range(1, 7);

                if (randomNumber == 1)
                {
                    Instantiate(NoPit, new Vector3(0, 0, zScenePos), NoPit.rotation);
                    Instantiate(Coin, new Vector3(0, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }
                if (randomNumber == 2)
                {
                    Instantiate(NoPit, new Vector3(0, 0, zScenePos), NoPit.rotation);
                    Instantiate(Coin, new Vector3(1, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }
                if (randomNumber == 3)
                {
                    Instantiate(NoPit, new Vector3(0, 0, zScenePos), NoPit.rotation);
                    Instantiate(Coin, new Vector3(-1, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }
                if (randomNumber == 4)
                {
                    Instantiate(RightPit, new Vector3(0, 0, zScenePos), RightPit.rotation);
                    Instantiate(Coin, new Vector3(0, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                    
                }
                if (randomNumber == 5)
                {
                    Instantiate(RightPit, new Vector3(0, 0, zScenePos), RightPit.rotation);
                    Instantiate(Coin, new Vector3(-1, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }
                if (randomNumber == 6)
                {
                    Instantiate(LeftPit, new Vector3(0, 0, zScenePos), LeftPit.rotation);
                    Instantiate(Coin, new Vector3(0, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }

                if (randomNumber == 7)
                {
                    Instantiate(NoPit, new Vector3(0, 0, zScenePos), NoPit.rotation);
                    Instantiate(Coin, new Vector3(1, 1, zScenePos), Coin.rotation);
                    zScenePos += 4;
                }

            }


            if (randomNumber == 4)
            {
                Instantiate(RightPit, new Vector3(0, 0, zScenePos), RightPit.rotation);
                Instantiate(Obstacle3, new Vector3(0, 1, zScenePos-2), Obstacle3.rotation);
                zScenePos += 4;
            }


            if (randomNumber == 5)
            {
                Instantiate(RightPit, new Vector3(0, 0, zScenePos), RightPit.rotation);
                Instantiate(Obstacle3, new Vector3(-1, 1, zScenePos), Obstacle3.rotation);
                zScenePos += 4;
            }

            if (randomNumber == 6)
            {
                Instantiate(MidPit, new Vector3(0, 0, zScenePos), MidPit.rotation);
                Instantiate(Obstacle2, new Vector3(1, 1, zScenePos-2), Obstacle2.rotation);
                zScenePos += 4;
            }


            if (randomNumber == 7)
            {
                Instantiate(MidPit, new Vector3(0, 0, zScenePos), MidPit.rotation);
                Instantiate(Obstacle2, new Vector3(-1, 1, zScenePos), Obstacle2.rotation);
                zScenePos += 4;
            }

            if (randomNumber == 8)
            {
                Instantiate(LeftPit, new Vector3(0, 0, zScenePos), LeftPit.rotation);
                Instantiate(Obstacle1, new Vector3(0, 1, zScenePos), Obstacle1.rotation);
                zScenePos += 4;
            }


            if (randomNumber == 9)
            {
                Instantiate(LeftPit, new Vector3(0, 0, zScenePos), LeftPit.rotation);
                Instantiate(Obstacle1, new Vector3(1, 1, zScenePos), Obstacle1.rotation);
                zScenePos += 4;
            }

            if (randomNumber > 9)
            {
                Instantiate(NoPit, new Vector3(0, 0, zScenePos), NoPit.rotation);
                zScenePos += 4;
            }
        }
	}
}
