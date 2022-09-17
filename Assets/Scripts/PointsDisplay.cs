using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsDisplay : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Points: " + KiteCollection.kites_count;
    }

    void Update() 
    {
        GetComponent<TextMeshProUGUI>().text = "Points: " + KiteCollection.kites_count;
    }
}
