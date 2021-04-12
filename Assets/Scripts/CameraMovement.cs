using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 6;
    public Vector3 CamVelocity;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerController>().canMove)
            transform.position += Vector3.forward * cameraSpeed ;
        CamVelocity = Vector3.forward * cameraSpeed ;
    }
}
