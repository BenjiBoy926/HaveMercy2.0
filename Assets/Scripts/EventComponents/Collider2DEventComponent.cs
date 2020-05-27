using UnityEngine;
using UnityEngine.Events;

public class Collider2DEventComponent : EventComponent<Collider2D>
{
    // TYPEDEFS

    [System.Serializable]
    private class Collider2DEvent : UnityEvent<Collider2D> { };

    // VARIABLES

    [SerializeField]
    [Tooltip("The name of the event")]
    private string _name;
    [SerializeField]
    private Collider2DEvent _event;

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
