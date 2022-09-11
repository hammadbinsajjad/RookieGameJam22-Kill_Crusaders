using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectToSpawn;
    [SerializeField] private  Vector3 start_point;
    [SerializeField] private Vector3 end_point;
    KiteAnimation animation;


    void Start()
    {
        Debug.Log("Spawner started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        //objectToSpawn.GetComponent<KiteAnimation>();
        animation = GetComponent<KiteAnimation>();
        animation.start_pont = start_point;
        animation.end_pont = end_point;
        Debug.Log("Values entered");
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
