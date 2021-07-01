using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public float x;
    public float y;
    public float z;

    // Update is called once per frame
    void Update()
    {   //float x, float y, float z
        Vector3 posVector = target.position + new Vector3(x, y, z);
        transform.position = posVector;
    }
}
