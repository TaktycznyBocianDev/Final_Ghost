using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEater : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject.GetComponentInParent<Transform>().gameObject);
        }
    }
}
