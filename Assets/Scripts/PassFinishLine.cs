using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassFinishLine : MonoBehaviour
{
    public static bool level_finished = false;

    [SerializeField] private Animator animator;

    [SerializeField] private Camera main_camera;

    int level_finish_animation_index = Animator.StringToHash("LevelFinished");

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("finish")) {

            level_finished = true;

            transform.LookAt(main_camera.transform);

            animator.SetTrigger(level_finish_animation_index);

            StartCoroutine(finish_level());
        }
    }

    IEnumerator finish_level() {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Congratulations");
    }
}
