using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KiteAnimationCleanup : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDisable() {
        DOTween.KillAll();
    }
}
