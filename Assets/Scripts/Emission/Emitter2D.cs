using UnityEngine;
using System.Collections;

public class Emitter2D : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The event component invoked when the emitter is emitted")]
    private GameObjectEventComponent eventComponent;

    public void Emit(GameObject prefab, Vector2 origin, Vector2 direction, float speed)
    {
        GameObject clone = Instantiate(prefab, new Vector3(origin.x, origin.y, prefab.transform.position.z), prefab.transform.rotation);
        Rigidbody2D cloneRigidbody = clone.GetComponent<Rigidbody2D>();

        if(cloneRigidbody != null)
        {
            cloneRigidbody.velocity = direction.normalized * speed;
            eventComponent.Invoke(clone);
        }
    }
}
