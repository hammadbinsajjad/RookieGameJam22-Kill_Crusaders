using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchInput : MonoBehaviour
{
    private Vector2 touch_start_position;

    private float side_movement_factor = 0.01f;

    private float turn_angle = 70;

    public static float forward_movement_speed = 0.3f;


    void Start() {
        // Freezinf rotation to only apply custom rotation
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update() {
            // Player forward movement
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + forward_movement_speed
            );

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            // Player side movement on drag
            if (touch.phase == TouchPhase.Began) {
                touch_start_position = touch.position;
            }

            float right_bound = Camera.main.rect.xMax + 1.8f;
            float left_bound = Camera.main.rect.xMin - 1.9f;

            if (touch.phase == TouchPhase.Moved) {
                
                float side_movement_speed = (touch.position.x - touch_start_position.x); 
                side_movement_speed *= side_movement_factor;
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x + side_movement_speed, left_bound, right_bound), 
                    transform.position.y, 
                    transform.position.z
                    );

                // Perform rotation based on finger drag
                if (side_movement_speed < 0 && (transform.rotation.y <= turn_angle && transform.rotation.y >= -turn_angle))
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -turn_angle, 0), Time.deltaTime*7f);
                else if (side_movement_speed > 0 && (transform.rotation.y >= -turn_angle && transform.rotation.y <= turn_angle))
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, turn_angle, 0), Time.deltaTime*7f);

                touch_start_position = touch.position;
            }

            // Reset the rotation if not dragging
            if (touch.phase == TouchPhase.Stationary) 
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime*7);

        }
        
        // Reset rotation if not touching
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime*7);
    }
}

