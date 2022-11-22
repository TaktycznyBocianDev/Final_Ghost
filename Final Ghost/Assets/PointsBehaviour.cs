using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsBehaviour : MonoBehaviour
{
    [SerializeField] Text pointsUI;
    private int points;

    private void Start()
    {
        points = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PointField"))
        {
            points += 1;
            pointsUI.text = points.ToString(); 
        }
    }
}
