using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -5) 
            SceneManager.LoadScene("Game Over");
    }
}
