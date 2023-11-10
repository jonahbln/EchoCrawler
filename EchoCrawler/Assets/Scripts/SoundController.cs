using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioClip sendEchoSound;
    [SerializeField] private AudioClip recieveEchoSound;
    [SerializeField] private AudioClip itemPickupSound;
    [SerializeField] private AudioClip winSound;
    private AudioSource AudioSource;

    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayEchoCall()
    {
        print("Echo sent sound");
        AudioSource.PlayClipAtPoint(sendEchoSound, transform.position);
    }

    public void PlayEchoResponse(float distanceTravelled)
    {
        switch (MathF.Floor(distanceTravelled))
        {
            case 0f:
                print("Echo recieved sound with distance 0");
                AudioSource.PlayClipAtPoint(recieveEchoSound, transform.position);
                break;

            case 1f:
                print("Echo recieved sound with distance 1");
                AudioSource.PlayClipAtPoint(recieveEchoSound, transform.position);
                break;

            case 2f:
                print("Echo recieved sound with distance 2");
                AudioSource.PlayClipAtPoint(recieveEchoSound, transform.position);
                break;

            case 3f:
                print("Echo recieved sound with distance 3");
                AudioSource.PlayClipAtPoint(recieveEchoSound, transform.position);
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
        AudioSource.PlayClipAtPoint(itemPickupSound, transform.position);
    }

    public void PlayStart()
    {
        print("Start Sound");
    }

    public void PlayWin()
    {
        print("Win Sound");
        AudioSource.PlayClipAtPoint(winSound, transform.position);
    }

    public void PlayLoss()
    {
        print("Loss Sound");
    }
}
