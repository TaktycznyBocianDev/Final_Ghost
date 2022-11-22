using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    private void Update()
    {
        transform.position += Vector3.left * movementSpeed;
    }
}
