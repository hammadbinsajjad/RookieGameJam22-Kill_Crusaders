using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KiteAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public  Vector3 start_pont;
    [SerializeField] public Vector3 end_pont;
    [SerializeField] private float fall_time = 9;
    [SerializeField] private int curves = 5;
    [SerializeField] private float amplitude = 0.5f;


    //To update values through the kite spwaner script.
    // void updateValues(Vector3 start, Vector3 end)
    // {
    //     start_pont = start;
    //     end_pont = end;
    // }


    void Start() {
        
        curves += 2;

        Vector3[] points = new Vector3[curves];
        
        transform.position = start_pont;


        // Set points for the animation
        float distance = end_pont.y - start_pont.y;

        float interval = distance / (curves - 1);

        points[0] = transform.position;

        Vector3 inter_pos = new Vector3(0, transform.position.y, transform.position.z);

        for (int i = 1; i < points.Length - 1; i++) {
            
            // Set the x_coordinate for interval
            if (i % 2 == 0) 
                inter_pos.x = transform.position.x + amplitude;
            else
                inter_pos.x = transform.position.x - amplitude;

            // Set the y component for interval
            inter_pos.y += interval;

            points[i] = inter_pos;
        }

        points[points.Length - 1] = end_pont;

        // Perform the animation on the points
        Sequence seq = DOTween.Sequence();

        seq.Append(
            transform?.DOPath(points, fall_time, PathType.CatmullRom)
        );
    }

   
}
