using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoHandler : MonoBehaviour
{
    [SerializeField] private GameObject echoProjectile;

    public static bool canEcho = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canEcho)
        {
            Instantiate(echoProjectile, transform.GetChild(0).transform.position, transform.rotation);
            canEcho = false;
            PlayerController.canMove = false;
        }
    }
}
