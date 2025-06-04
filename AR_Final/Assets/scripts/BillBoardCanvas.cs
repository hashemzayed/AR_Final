using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardCanvas : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // AR Camera
    }

    void Update()
    {
        if (mainCamera != null)
        {
            // Make the canvas face the camera
            transform.LookAt(mainCamera.transform);
            // Flip it to face forward, not backwards
            transform.Rotate(0, 180f, 0);
        }
    }
}

