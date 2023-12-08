using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioClip sendEchoSound;
    [SerializeField] private AudioClip recieveEchoSoundDefault;
    [SerializeField] private AudioClip recieveEchoSoundDoor;
    [SerializeField] private AudioClip hitWallSound;
    [SerializeField] private AudioClip movefowardSound;
    [SerializeField] private AudioClip rotateLeftSound;
    [SerializeField] private AudioClip rotateRightSound;
    [SerializeField] private AudioClip itemPickupSound;
    [SerializeField] private AudioClip winSound;
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

    public void PlayEchoResponse(bool door)
    {
        if(door)
        {
            AudioSource1.PlayOneShot(recieveEchoSoundDefault);
            AudioSource2.PlayOneShot(recieveEchoSoundDoor);
        }
        else
        {
            AudioSource2.PlayOneShot(recieveEchoSoundDefault);
        }
    }

    public void PlayWallInteraction()
    {
        print("Wall hit sound");
        AudioSource2.PlayOneShot(hitWallSound);
    }

    public void PlayPickup()
    {
        print("Pickup Sound");
        AudioSource2.PlayOneShot(itemPickupSound);
    }

    public void PlayStart()
    {
        print("Start");
    }

    public void PlayWin()
    {
        print("Win Sound");
        AudioSource2.PlayOneShot(winSound );
    }

    public void PlayLoss()
    {
        print("Loss Sound");
    }

    public void PlayMoveFoward()
    {
        AudioSource1.PlayOneShot(movefowardSound);
    }

    public void PlayRotateLeft()
    {
        AudioSource1.PlayOneShot(rotateLeftSound);
    }

    public void PlayRotateRight()
    {
        AudioSource1.PlayOneShot(rotateRightSound);
    }
}
