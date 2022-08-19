using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchInput : MonoBehaviour
{
    private Vector2 touch_start_position;
    private float side_movement_speed = 0.2f;

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);

            // The buildings move start moving when clicked will be implemented here

            // Player side movement is implemented here
            if (touch.phase == TouchPhase.Began) {
                touch_start_position = touch.position;
            }

            float right_bound = Camera.main.rect.xMax + 1.8f;
            float left_bound = Camera.main.rect.xMin - 1.9f;

            if (touch.phase == TouchPhase.Moved) {
                if (touch.position.x > touch_start_position.x) {
                    transform.position = new Vector3(
                        Mathf.Clamp(transform.position.x + side_movement_speed, left_bound, right_bound), 
                        transform.position.y, 
                        transform.position.z
                        );

                }

                else if (touch.position.x < touch_start_position.x) {
                    transform.position = new Vector3(
                        Mathf.Clamp(transform.position.x - side_movement_speed, left_bound, right_bound), 
                        transform.position.y, 
                        transform.position.z
                        );
                }

                touch_start_position = touch.position;
            }
        }
    }
}
