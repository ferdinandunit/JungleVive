using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBawah : MonoBehaviour
{
    public float distance, speed;
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private bool isActive = false;

    void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition - new Vector3(0, distance, 0);
    }

    void Update()
    {
        if (isActive)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                isActive = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isActive = true;
        }
    }
}
