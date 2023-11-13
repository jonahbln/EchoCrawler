using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EchoProjectile : MonoBehaviour
{
    private float timeSinceBirth = 0f;
    [SerializeField] private float projSpeed = 1f;
    private SoundController soundController;
    private Rigidbody2D rb;
    private Vector2 upDirection;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        soundController = FindObjectOfType<SoundController>();
        upDirection = transform.up;
        soundController.PlayEchoCall();
        rb.velocity = upDirection * projSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceBirth += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.CompareTag("Wall"))
        {
            soundController.PlayEchoResponse(Mathf.Round(timeSinceBirth * projSpeed));
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            soundController.PlayEchoResponse(Mathf.Round(timeSinceBirth * projSpeed));
            Destroy(gameObject);
        }
    }
}
