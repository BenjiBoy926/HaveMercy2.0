using UnityEngine;
using System.Collections;

public class RigidbodyBinding2D : MonoBehaviour
{
    // VARIABLES
    [SerializeField]
    [Tooltip("Center of the box where the rigidbody is bound")]
    private Vector2 middle;

    [SerializeField]
    [Tooltip("Distance from center to the horizontal sides of the bounding box")]
    private float horizontalExtent;

    [SerializeField]
    [Tooltip("Distance from the center to the vertical sides of the bounding box")]
    private float verticalExtent;

    private Rigidbody2D _target;

    // PROPERTIES
    public Rigidbody2D target
    {
        get
        {
            if(_target == null)
            {
                _target = GetComponent<Rigidbody2D>();
            }
            return _target;
        }
    }

    private void Update()
    {
        target.position = new Vector2 (
            Mathf.Clamp(target.position.x, middle.x - horizontalExtent, middle.x + horizontalExtent), 
            Mathf.Clamp(target.position.y, middle.y - verticalExtent, middle.y + verticalExtent)
        );
    }
}
