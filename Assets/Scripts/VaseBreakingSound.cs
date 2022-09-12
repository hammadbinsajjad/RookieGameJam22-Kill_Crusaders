using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBreakingSound : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            GetComponent<AudioSource>().Play();
            for (int i = 0; i < transform.childCount; i++) {
                transform.GetChild(i).gameObject.SetActive(false);
            }
            GetComponent<BoxCollider>().enabled = false;
            KiteCollection.kites_count--;
        }
    }
}
