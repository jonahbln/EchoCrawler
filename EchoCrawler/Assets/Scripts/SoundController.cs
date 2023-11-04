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

    public void PlayEchoCall()
    {
        print("Echo sent");
    }

    public void PlayEchoResponse(float distanceTravelled)
    {
        switch (MathF.Floor(distanceTravelled))
        {
            case 0f:
                print("Echo heard with distance 0");
                break;

            case 1f:
                print("Echo heard with distance 1");
                break;

            case 2f:
                print("Echo heard with distance 2");
                break;

            case 3f:
                print("Echo heard with distance 3");
                break;

            default:
                print("Echo heard with distance unkown");
                break;
        }
    }

    public void PlayWallInteraction()
    {
        print("Wall hit");
    }
}
