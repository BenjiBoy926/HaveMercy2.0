using UnityEngine;

public class TriggerEvents2D : MonoBehaviour
{
    [SerializeField]
    private Collider2DEventComponent onTrigger2DEnter;
    [SerializeField]
    private Collider2DEventComponent onTrigger2DStay;
    [SerializeField]
    private Collider2DEventComponent onTrigger2DExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger2DEnter.Invoke(collision);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        onTrigger2DStay.Invoke(collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onTrigger2DExit.Invoke(collision);
    }
}
