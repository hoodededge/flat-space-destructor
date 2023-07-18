using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Camera Controller
[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    // Camera's Controlled by Script
    [HideInInspector] private Camera playerCamera = null;

    [Header("--- TARGET ---")]
    [Tooltip("Camera Target")]
    public Transform target = null;

    [Tooltip("Camera Zoom")]
    public float cameraZoom = -10.0f;

    // Input Manager (for reading player inputs)
    private InputManager inputManager;

    // Start
    void Start()
    {
        playerCamera = GetComponent<Camera>();

        if (inputManager == null)
        {
            inputManager = InputManager.instance;

            Debug.LogWarning("Camera Controller Can't Find Input Manager!");
        }
    }

    // Set Camera Position
    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = GetTargetPosition();
            Vector3 desiredCameraPosition = ComputeCameraPosition(targetPosition);

            transform.position = desiredCameraPosition;
        }
    }

    // Get Target Position
    public Vector3 GetTargetPosition()
    {
        if (target != null)
        {
            return target.position;
        }

        return transform.position;
    }

    // Compute Camera Position
    public Vector3 ComputeCameraPosition(Vector3 targetPosition)
    {
        Vector3 result = Vector3.zero;
        
        result = targetPosition;

        result.z = cameraZoom;

        return result;
    }
}
