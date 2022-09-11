using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonActions : MonoBehaviour
{
    public void GoToLevelScreen() {
        SceneManager.LoadScene("Select Levels");
    }

    public void Quit() {
        Application.Quit();
    }
}
