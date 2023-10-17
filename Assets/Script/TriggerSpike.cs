using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpike : MonoBehaviour
{
    public bool isActive;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
