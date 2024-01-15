using Oculus.Interaction;
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
        //if (!colliders.Contains(collision.gameObject))
        //{
           
        //}
            colliders.Add(collision.gameObject);
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<TouchHandGrabInteractable>().enabled = false;
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<Grabbable>().enabled = false;
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        
    }

    void OnTriggerExit(Collider collision)
    {
        // Destroy everything that leaves the trigger
        colliders.Remove(collision.gameObject);
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<TouchHandGrabInteractable>().enabled = true;
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<Grabbable>().enabled = true;
        collision.gameObject.GetComponent<BehindObject>().behindObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
