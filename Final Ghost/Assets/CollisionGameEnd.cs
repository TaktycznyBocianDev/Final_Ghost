using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGameEnd : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject obstacleSpawner;
    
    private PlayerMovement playerMovement;
    private Rigidbody2D rb;


    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            playerMovement.enabled = false;
            transform.position = new Vector3(0, -10, 0);
            rb.gravityScale = 0;
            gameOverScreen.SetActive(true);
            Destroy(obstacleSpawner);
        }
    }

}
