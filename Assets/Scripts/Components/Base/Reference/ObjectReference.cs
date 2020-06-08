using UnityEngine;

[System.Serializable]
public class ObjectReference : Reference<Object>
{
    [SerializeField]
    [Tooltip("Type of reference")]
    private ReferenceType type;

    [SerializeField]
    [Tooltip("Component used to get the int, in the case of a variable reference type")]
    private ObjectVariable component = null;

    [SerializeField]
    [Tooltip("Value in the reference")]
    private GameObject value;

    public override Object GetValue()
    {
        switch (type)
        {
            case ReferenceType.Value: return value;
            case ReferenceType.Reference: return component.GetValue();
            default: return value;
        }
    }

    public override Variable<Object> GetReference()
    {
        return component;
    }
}
