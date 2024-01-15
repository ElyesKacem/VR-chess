using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderList : MonoBehaviour
{
    public static List<GameObject> colliders;
    // Start is called before the first frame update
    void Start()
    {
        colliders = new List<GameObject>();
    }
  
    private void OnTriggerEnter(Collider collision)
    {
        if (!colliders.Contains(collision.gameObject))
        {
            Debug.Log("hi");
        }
            colliders.Add(collision.gameObject);
        
    }

    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        colliders.Remove(other.gameObject);
    }
}
