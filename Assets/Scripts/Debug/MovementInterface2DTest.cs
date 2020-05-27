using UnityEngine;
using System.Collections;

public class MovementInterface2DTest : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Movement interface script to test")]
    private MovementInterface2D movement;

    [SerializeField]
    [Tooltip("Position the script will glide to")]
    private Vector2 glidePosition;
    [SerializeField]
    [Tooltip("Time it will take for the script to glide")]
    private float glideTime;

    private void Start()
    {
        movement.GlideToPoint(glidePosition, glideTime);
    }
}
