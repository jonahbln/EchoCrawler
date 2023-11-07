using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EchoProjectile : MonoBehaviour
{
    private float timeSinceBirth = 0f;
    [SerializeField] private float projSpeed = 0.2f;
    private SoundController soundController;
    private Rigidbody2D rb;
    private Vector2 upDirection;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        soundController = FindObjectOfType<SoundController>();
        upDirection = transform.up;
        soundController.PlayEchoCall();
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
            soundController.PlayEchoResponse(Mathf.Round(timeSinceBirth));
            Destroy(gameObject);
        }
    }

    

    private void FixedUpdate()
    {
        rb.velocity = upDirection * projSpeed;
    }

}
