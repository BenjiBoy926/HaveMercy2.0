using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ValueUpdateIntEventComponent : EventComponent<ValueUpdate<int>>
{
    // TYPEDEFS

    [System.Serializable]
    private class ValueUpdateIntEvent : UnityEvent<ValueUpdate<int>> { };

    // VARIABLES

    [SerializeField]
    [Tooltip("The name of the event")]
    private string _name;
    [SerializeField]
    private ValueUpdateIntEvent _event;

    // FUNCTIONS

    public override string GetName()
    {
        return _name;
    }

    public override UnityEvent<ValueUpdate<int>> GetEvent()
    {
        return _event;
    }
}
