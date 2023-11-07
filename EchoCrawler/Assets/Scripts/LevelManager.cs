using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static bool canExit = false;
    private Vector3 doorLocation;
    private float doorRotation;
    [SerializeField] private float playTime;
    [SerializeField] private GameObject doorPrefab;
    [SerializeField] private GameObject player;
    private SoundController soundController;

    // Start is called before the first frame update
    void Start()
    {
        soundController = GetComponent<SoundController>();

        doorLocation = player.transform.position;
        doorRotation = player.transform.rotation.eulerAngles.z;
        if(doorRotation ==0)
        {
            doorLocation.y += 1;
        } else if(doorRotation == 90) 
        {
            doorLocation.x += 1;
        } else if (doorRotation == 180)
        {
            doorLocation.y -= 1;
        } else if (doorRotation == 270)
        {
            doorLocation.x -= 1;
        }
        Instantiate(doorPrefab, doorLocation, new Quaternion(0,0,0,0), transform);

        soundController.PlayStart();
    }

    // Update is called once per frame
    void Update()
    {
        playTime += Time.deltaTime;
    }

    public void treasurePickup()
    {
        canExit = true;
        print("Treasure picked up in: " + playTime + " seconds!");
    }

    public void levelWon()
    {
        print("Level won in: " + playTime + " seconds!");
        soundController.PlayWin();
    }

    public void levelLost()
    {
        print("Level lost in: " + playTime + " seconds!");
        soundController.PlayLoss();
    }
}