// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Spawner : MonoBehaviour
// {
//     // Start is called before the first frame update

//     public GameObject objectToSpawn;
//     [SerializeField] private  Vector3 start_point;
//     [SerializeField] private Vector3 end_point;
//     public KiteAnimation animation;


//     void Start()
//     {
//         Debug.Log("Spawner started");
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     public void SpawnObject()
//     {
//         //objectToSpawn.GetComponent<KiteAnimation>();
//         // animation = GetComponent<KiteAnimation>();
//         // animation.start_pont = start_point;
//         // animation.end_pont = end_point;
//         // Debug.Log("Values entered");
//         Instantiate(objectToSpawn, transform.position, transform.rotation);
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private KiteAnimation kite_animation;
    public GameObject objectToSpawn;
    public  Vector3 start_point;
    public Vector3 end_point;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(objectToSpawn,transform.position,objectToSpawn.transform.rotation);//Quaternion.identity means no rotation
        
    }

    public void SpawnObject()
    {
        float fall = Mathf.Clamp(Mathf.Abs(0.05f * (end_point.y * start_point.y)), 2f, 5f); 
        kite_animation = objectToSpawn.GetComponent<KiteAnimation>();
        kite_animation.updateValues( start_point,  end_point, fall);
        Instantiate(objectToSpawn);
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
