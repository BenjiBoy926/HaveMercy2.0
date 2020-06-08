using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ValueUpdateGameObjectEventComponent : EventComponent<ValueUpdate<GameObject>>
{
    // TYPEDEFS

    [System.Serializable]
    private class UnityEventSubtype : UnityEvent<ValueUpdate<GameObject>> { };

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

    public override UnityEvent<ValueUpdate<GameObject>> GetEvent()
    {
        return _event;
    }
}
