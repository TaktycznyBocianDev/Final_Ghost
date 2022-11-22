using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("How strong is player hit up")]
    [SerializeField] float jumpForce;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerGoUp(jumpForce);
        }
    }

    private void PlayerGoUp(float jumpForce)
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
