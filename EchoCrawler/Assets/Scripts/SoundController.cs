using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayEcho(float distanceTravelled)
    {
        switch (distanceTravelled)
        {
            case 0:
                print("Echo heard with distance 0");
                break;

            case 1:
                print("Echo heard with distance 1");
                break;

            case 2:
                print("Echo heard with distance 2");
                break;

            case 3:
                print("Echo heard with distance 3");
                break;

            default:
                print("Echo heard with distance unkown");
                break;
        }
    }
}
