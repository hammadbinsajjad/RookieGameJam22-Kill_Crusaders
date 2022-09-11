using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels: MonoBehaviour
{
    public void LoadLevel1() {
        SceneManager.LoadScene("Level_1");
        RetryButtonActions.prevLevel = 1;
    }

    public void LoadLevel2() {
        SceneManager.LoadScene("Level_2");
        RetryButtonActions.prevLevel = 2;
    }

    public void LoadLevel3() {
        SceneManager.LoadScene("Level_3");
        RetryButtonActions.prevLevel = 3;
    }
}
