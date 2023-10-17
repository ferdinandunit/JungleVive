using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed;
    

    void Update()
    {
        transform.Translate(new Vector2(movementSpeed * Time.deltaTime,0f));
    }

}
