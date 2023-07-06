using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float heightOfCamera = 10;
    public float FollowSpeed = 10;
    public Transform target;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, target.position.y + heightOfCamera, -10f);
    }
}
