using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0) {
            
            float forward_movement_speed = PlayerTouchInput.forward_movement_speed;

            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + forward_movement_speed
            );
        }
    }
}
