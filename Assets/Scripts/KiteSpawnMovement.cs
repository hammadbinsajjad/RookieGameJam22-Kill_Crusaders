using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KiteSpawnMovement : MonoBehaviour
{
    [SerializeField] private Vector3 starting_position;
    [SerializeField] private Vector3 ending_position;

    // Start is called before the first frame update
    void Start()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOMove(ending_position, 2))
            .Join(transform.DORotate(new Vector3(0, 0, -25), 2));
    }
}
