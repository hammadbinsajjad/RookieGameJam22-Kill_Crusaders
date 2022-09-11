using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteCollection : MonoBehaviour
{
    public static int kites_count = 0;
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("kite")) {
            kites_count++;
            other.gameObject.SetActive(false);
            Debug.Log(kites_count);
        }
    }
}
