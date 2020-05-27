using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // VARIABLES
    [SerializeField]
    [Tooltip("The speed of the player's movement")]
    private float speed;

    [SerializeField]
    [Tooltip("The script that controls the player's movement")]
    private MovementInterface2D movement;

    private PlayerInputActions input;
    private Vector2 movementDir = Vector2.zero;

    private void Awake()
    {
        input = new PlayerInputActions();

        // Being a literal TWAT and refusing to work
        input.Gameplay.Move.performed += ctx =>
        {
            movementDir = ctx.ReadValue<Vector2>();
        };
    }

    private void Update()
    {
        //movement.SetVelocity(movementDir, speed);

        movementDir.x = Input.GetAxisRaw("Horizontal");
        movementDir.y = Input.GetAxisRaw("Vertical");

        movement.SetVelocity(movementDir * speed);
    }
}
