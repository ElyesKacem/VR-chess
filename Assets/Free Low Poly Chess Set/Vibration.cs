using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    public GameObject inFrontObject;
    private Vector3 initPosition;
    // Start is called before the first frame update
    void Start()
    {
        initPosition=inFrontObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(ColliderList.colliders.Contains(inFrontObject))
        {
            inFrontObject.transform.position = initPosition;
            OVRInput.SetControllerVibration(10, 10);
        }
    }
}
