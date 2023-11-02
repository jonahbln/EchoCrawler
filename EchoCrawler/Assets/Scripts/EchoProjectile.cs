using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EchoProjectile : MonoBehaviour
{
    private float timeSinceBirth = 0f;
    [SerializeField] private float projSpeed = 0.2f;
    private GameObject player;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = transform.parent.gameObject;
        
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
            player.GetComponent<SoundController>().PlayEchoResponse(Mathf.Round(timeSinceBirth));
            Destroy(gameObject);
        }
    }

    

    private void FixedUpdate()
    {
        rb.velocity = transform.up * projSpeed;
    }

}
