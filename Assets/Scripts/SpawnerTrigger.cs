// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SpawnerTrigger : MonoBehaviour
// {
//     public Spawner spawner;

//     void OnTriggerEnter(Collider other)
//     {

//         Debug.Log("inside on trigger");
//         if(other.gameObject.CompareTag("Player"))
//         {
//             Debug.Log("inside on trigger");
//            spawner.SpawnObject();
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public Spawner spawner;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision Detected");
            spawner.SpawnObject();
        }
    }
    
   
}
