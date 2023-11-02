using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EchoProjectile : MonoBehaviour
{
    private float timeSinceBirth = 0f;
    [SerializeField] private float projSpeed = 0.2f;
    private SoundController playerSoundController;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSoundController = FindObjectOfType<SoundController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("HIT");
        if(collision.otherCollider.gameObject.CompareTag("Wall"))
        {
            playerSoundController.PlayEcho(timeSinceBirth);
        }
    }

    

    private void FixedUpdate()
    {
        timeSinceBirth += 1f;

        rb.velocity = transform.up * projSpeed;
    }
}
