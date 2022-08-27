using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchInput : MonoBehaviour
{
    private Vector2 touch_start_position;

    private float side_movement_factor = 0.01f;

    public static float forward_movement_speed = 0.2f;


    void Start() {
        // Setting rigidbody rotation to none for testing
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            // Player forward movement on touch
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + forward_movement_speed
            );

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

                touch_start_position = touch.position;
            }
        }
    }
}

