using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioClip sendEchoSound;
    [SerializeField] private AudioClip recieveEchoSound0;
    [SerializeField] private AudioClip recieveEchoSound1;
    [SerializeField] private AudioClip recieveEchoSound2;
    [SerializeField] private AudioClip recieveEchoSound3;
    [SerializeField] private AudioClip hitWallSound;
    [SerializeField] private AudioClip hitWallWarningSound;
    [SerializeField] private AudioClip movefowardSound;
    [SerializeField] private AudioClip rotateLeftSound;
    [SerializeField] private AudioClip rotateRightSound;
    [SerializeField] private AudioClip itemPickupSound;
    [SerializeField] private AudioClip winSound;
    [SerializeField] private AudioClip recieveEchoSoundDefault;
    [SerializeField] private AudioSource AudioSource1;
    [SerializeField] private AudioSource AudioSource2;

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
        AudioSource1.PlayOneShot(sendEchoSound);
    }

    public void PlayEchoResponse(float distanceTravelled)
    {
        switch (MathF.Floor(distanceTravelled))
        {
            case 0f:
                print("Echo recieved sound with distance 0");
                AudioSource2.PlayOneShot(recieveEchoSound0 );
                break;

            case 1f:
                print("Echo recieved sound with distance 1");
                AudioSource2.PlayOneShot(recieveEchoSound1 );
                break;

            case 2f:
                print("Echo recieved sound with distance 2");
                AudioSource2.PlayOneShot(recieveEchoSound2 );
                break;

            case 3f:
                print("Echo recieved sound with distance 3");
                AudioSource2.PlayOneShot(recieveEchoSound3  );
                break;

            default:
                print("Echo recieved sound with distance unkown");
                AudioSource2.PlayOneShot(recieveEchoSoundDefault  );
                break;
        }
    }

    public void PlayWallInteraction()
    {
        print("Wall hit sound");
        AudioSource2.Pause();
        //AudioSource2.PlayOneShot(hitWallWarningSound);
        AudioSource1.PlayOneShot(hitWallSound);
    }

    public void PlayPickup()
    {
        print("Pickup Sound");
        AudioSource1.PlayOneShot(itemPickupSound);
    }

    public void PlayStart()
    {
        print("Start");
    }

    public void PlayWin()
    {
        print("Win Sound");
        AudioSource1.PlayOneShot(winSound );
    }

    public void PlayLoss()
    {
        print("Loss Sound");
    }

    public void PlayMoveFoward()
    {
        AudioSource2.PlayOneShot(movefowardSound  );
    }

    public void PlayRotateLeft()
    {
        AudioSource1.PlayOneShot(rotateLeftSound  );
    }

    public void PlayRotateRight()
    {
        AudioSource1.PlayOneShot(rotateRightSound  );
    }
}
