using UnityEngine;
using UnityEngine.Events;

public class Collider2DEventComponent : EventComponent<Collider2D>
{
    // TYPEDEFS

    [System.Serializable]
    private class UnityEventSubtype : UnityEvent<Collider2D> { };

    // VARIABLES

    [SerializeField]
    [Tooltip("The name of the event")]
    private string _name;
    [SerializeField]
    private UnityEventSubtype _event;

    // FUNCTIONS

    public override string GetName()
    {
        return _name;
    }

    public override UnityEvent<Collider2D> GetEvent()
    {
        return _event;
    }
}
