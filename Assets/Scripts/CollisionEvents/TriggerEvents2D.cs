using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents2D : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Reference to the GameObject that will store the GameObject that triggered the event")]
    private GameObjectVariable otherInCollision;

    [SerializeField]
    private UnityEvent onTrigger2DEnter;
    [SerializeField]
    private UnityEvent onTrigger2DStay;
    [SerializeField]
    private UnityEvent onTrigger2DExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        otherInCollision.SetValue(collision.gameObject);
        onTrigger2DEnter.Invoke();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        otherInCollision.SetValue(collision.gameObject);
        onTrigger2DStay.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        otherInCollision.SetValue(collision.gameObject);
        onTrigger2DExit.Invoke();
    }
}
