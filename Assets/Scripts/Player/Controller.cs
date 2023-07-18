using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Controller class
public class Controller : MonoBehaviour
{
    [Header("--- GameObject / Component References ---")]
    [Tooltip("The animator controller used to animate the player.")]
    public RuntimeAnimatorController animator = null;

    [Header("--- Movement Variables ---")]
    [Tooltip("The speed at which the player will move.")]
    public float moveSpeed = 10.0f;

    //The InputManager to read input from
    private InputManager inputManager;

    // Start function
    private void Start()
    {
        SetupInput();
    }

    // Update function
    void Update()
    {
        // Collect input and move the player accordingly
        HandleInput();
        // Sends information to an animator component if one is assigned
        SignalAnimator();
    }

    // Setup Function
    private void SetupInput()
    {
        if (inputManager == null)
        {
            inputManager = InputManager.instance;
        }
        if (inputManager == null)
        {
            Debug.LogWarning("There is no player input manager in the scene, there needs to be one for the Controller to work");
        }
    }

    // Handle Function
    private void HandleInput()
    {
        // Find the position that the player should look at
        Vector2 lookPosition = GetLookPosition();
        // Get movement input from the inputManager
        Vector3 movementVector = new Vector3(inputManager.horizontalMoveAxis, inputManager.verticalMoveAxis, 0);
        // Move the player
        MovePlayer(movementVector);
        LookAtPoint(lookPosition);
    }

    // Signal Animator Function
    private void SignalAnimator()
    {
        // Handle Animation
        if (animator != null)
        {

        }
    }

    // Get Look Position Function
    public Vector2 GetLookPosition()
    {
        return new Vector2(inputManager.horizontalLookAxis, inputManager.verticalLookAxis);
    }

    // Move Player Function
    /// <param name = "movement">The direction to move the player</param>
    private void MovePlayer(Vector3 movement)
    {
        // Set the player's posiiton accordingly

        // Move according to astroids setting
        transform.position = transform.position + (movement * Time.deltaTime * moveSpeed);
    }

    // Look at Point Function
    /// <param name = "point">The screen space position to look at</param>
    private void LookAtPoint(Vector3 point)
    {
        if (Time.timeScale > 0)
        {
            // Rotate the player to look at the mouse.
            Vector2 lookDirection = Camera.main.ScreenToWorldPoint(point) - transform.position;

            transform.up = lookDirection;
        }
    }
}
