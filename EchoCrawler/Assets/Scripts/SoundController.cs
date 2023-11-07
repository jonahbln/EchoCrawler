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
        print("Echo sent sound");
    }

    public void PlayEchoResponse(float distanceTravelled)
    {
        switch (MathF.Floor(distanceTravelled))
        {
            case 0f:
                print("Echo recieved sound with distance 0");
                break;

            case 1f:
                print("Echo recieved sound with distance 1");
                break;

            case 2f:
                print("Echo recieved sound with distance 2");
                break;

            case 3f:
                print("Echo recieved sound with distance 3");
                break;

            default:
                print("Echo recieved sound with distance unkown");
                break;
        }
    }

    public void PlayWallInteraction()
    {
        print("Wall hit sound");
    }

    public void PlayPickup()
    {
        print("Pickup Sound");
    }

    public void PlayStart()
    {
        print("Start Sound");
    }

    public void PlayWin()
    {
        print("Win Sound");
    }

    public void PlayLoss()
    {
        print("Loss Sound");
    }
}
