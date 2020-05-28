using UnityEngine;
using UnityEngine.Events;

public class ValueUpdateFloatEventComponent : EventComponent<ValueUpdate<float>>
{
    // TYPEDEFS

    [System.Serializable]
    private class UnityEventSubtype : UnityEvent<ValueUpdate<float>> { };

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

    public override UnityEvent<ValueUpdate<float>> GetEvent()
    {
        return _event;
    }
}
