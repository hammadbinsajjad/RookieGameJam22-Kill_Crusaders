using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonActions : MonoBehaviour
{
    public static int prevLevel;
    // Start is called before the first frame update
    public void LoadPrevLevel() {
        if (prevLevel == 1)
            SceneManager.LoadScene("Level_1");
        if (prevLevel == 2)
            SceneManager.LoadScene("Level_2");
        if (prevLevel == 3)
            SceneManager.LoadScene("Level_3");
    }
}
