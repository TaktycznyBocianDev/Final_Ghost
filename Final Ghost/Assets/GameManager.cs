using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private Rigidbody2D playerRb;
    private PlayerMovement playerMovement;

    [SerializeField] float gravitiScale = 0.7f;


    private void Start()
    {
        playerRb = Player.GetComponent<Rigidbody2D>();
        playerMovement = Player.GetComponent<PlayerMovement>();
        playerRb.gravityScale = 0;
    }

    public void StartTheGame()
    {
        playerMovement.enabled = true;
        playerRb.gravityScale = gravitiScale;
    }

    
}
