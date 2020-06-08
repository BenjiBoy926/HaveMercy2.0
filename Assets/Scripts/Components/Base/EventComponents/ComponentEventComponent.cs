using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ComponentEventComponent : EventComponent<Component>
{
    // TYPEDEFS

    [System.Serializable]
    private class UnityEventSubtype : UnityEvent<Component> { };

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

    public override UnityEvent<Component> GetEvent()
    {
        return _event;
    }
}
