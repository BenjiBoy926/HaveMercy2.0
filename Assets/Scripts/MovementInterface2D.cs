using UnityEngine;
using System.Collections;

public class MovementInterface2D : MonoBehaviour
{
    // VARIABLES
    private Rigidbody2D _rb2D;

    private bool isGliding = false;
    private Vector2 glideStart;
    private Vector2 glideEnd;
    private float glideInverseTime;
    private float glideInterpolator;

    // PROPERTIES
    private Rigidbody2D rb2D
    {
        get
        {
            if(_rb2D == null)
            {
                _rb2D = GetComponent<Rigidbody2D>();
            }
            return _rb2D;
        }
    }

    // FUNCTIONS
    public void SetVelocity(Vector2 dir, float speed)
    {
        SetVelocity(dir.normalized * speed);
    }
    public void SetVelocity(Vector2 vector)
    {
        rb2D.velocity = vector;
    }

    public void GlideToPoint(Vector2 point, float time)
    {
        rb2D.velocity = Vector2.zero;

        glideStart = rb2D.position;
        glideEnd = point;
        glideInverseTime = 1.0f / time;
        glideInterpolator = 0;

        isGliding = true;
    }

    public void StopGliding()
    {
        isGliding = false;
    }

    private void Update()
    {
        if(isGliding)
        {
            GlideStep();
        }
    }

    private void GlideStep()
    {
        if(glideInterpolator <= 1)
        {
            glideInterpolator += Time.deltaTime * glideInverseTime;
            rb2D.position = (1 - glideInterpolator) * glideStart + glideInterpolator * glideEnd;
        }
        else
        {
            isGliding = false;
        }
    }
}
