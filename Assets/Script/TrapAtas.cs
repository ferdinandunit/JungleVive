using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAtas : MonoBehaviour
{
    public float distance, speed, timeStart;
    private float originalPosY;
    public float maxTargetY;
    public bool isActive;

    void Start()
    {
        originalPosY = transform.localPosition.y;
        maxTargetY = originalPosY + distance;
    }

    void Update()
    {
        if (transform.localPosition.y < maxTargetY && isActive)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(transform.localPosition.x, transform.localPosition.y + distance), speed * Time.deltaTime);
        }
        else if (transform.localPosition.y >= maxTargetY) 
        {
            isActive= false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isActive= true;
        }
    }
}
