using UnityEngine;
using System.Collections;

public class RigidbodyBinding2D : MonoBehaviour
{
    // VARIABLES
    [SerializeField]
    [Tooltip("Center of the box where the rigidbody is bound")]
    private Vector2 origin;

    [SerializeField]
    [Tooltip("Distance from center to the horizontal / vertical sides of the bounding box")]
    private Vector2 extents;

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
            Mathf.Clamp(target.position.x, origin.x - extents.x, origin.x + extents.x), 
            Mathf.Clamp(target.position.y, origin.y - extents.y, origin.y + extents.y)
        );
    }
}
