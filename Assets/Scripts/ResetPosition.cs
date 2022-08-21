using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject player_cam;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -5f) {
            player.transform.position = new Vector3(0.3f, -2f, -0.064f);
            player_cam.transform.position = new Vector3(0.27f, 1, -10);
        }
        
    }
}
