using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{
    public static bool canExit = false;
    private Vector3 doorLocation;
    private float doorRotation;
    [SerializeField] private float playTime;
    [SerializeField] private GameObject doorPrefab;
    private GameObject player;
    [SerializeField] private string LevelToLoad;
    private DoorController doorController;
    private SoundController soundController;
    private Vector3 startPosition = new Vector3(4.5f,0.5f,0.0f);
    private Quaternion startRotation = Quaternion.Euler(0f, 0f, 90f);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        soundController = FindObjectOfType<SoundController>();

        player.GetComponent<PlayerController>().stopMoving();

        player.transform.rotation = startRotation;
        player.transform.position = startPosition;

        doorLocation = player.transform.position;
        doorRotation = player.transform.rotation.eulerAngles.z;

        if(doorRotation ==0)
        {
            doorLocation.y -= 1;
        } else if(doorRotation == 90) 
        {
            doorLocation.x += 1;
        } else if (doorRotation == 180)
        {
            doorLocation.y += 1;
        } else if (doorRotation == 270)
        {
            doorLocation.x -= 1;
        }
        Instantiate(doorPrefab, doorLocation, new Quaternion(0,0,0,0), transform);
        doorController = FindObjectOfType<DoorController>();

        soundController.PlayStart();

        player.GetComponent<PlayerController>().enabled = true;
        player.GetComponent<EchoHandler>().enabled = true;
    }

    

    // Update is called once per frame
    void Update()
    {
        playTime += Time.deltaTime;
    }

    public void treasurePickup()
    {
        canExit = true;
        doorController.itemPickup();
        print("Treasure picked up in: " + playTime + " seconds!");
    }

    public void levelWon()
    {
        print("Level won in: " + playTime + " seconds!");
        soundController.PlayWin();

        SceneManager.LoadScene(LevelToLoad);
               
    }

    public void levelLost()
    {
        print("Level lost in: " + playTime + " seconds!");
        soundController.PlayLoss();
    }
}
