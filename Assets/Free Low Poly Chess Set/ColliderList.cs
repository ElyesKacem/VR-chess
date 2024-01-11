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

    // Update is called once per frame
    void Update()
    {
        Debug.Log(colliders.Count);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!colliders.Contains(collision.gameObject))
        {
            Debug.Log("hi");
        }
            colliders.Add(collision.gameObject);
    }
}
