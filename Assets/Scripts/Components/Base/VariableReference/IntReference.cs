using UnityEngine;
using System.Collections;

[System.Serializable]
public class IntReference : VariableReference<int>
{
    [SerializeField]
    [Tooltip("Type of reference")]
    private VariableReferenceType type;

    [SerializeField]
    [Tooltip("Component used to get the int, in the case of a variable reference type")]
    private IntComponent component = null;

    [SerializeField]
    [Tooltip("Value in the reference")]
    private int value;

    public override int GetValue()
    {
        switch(type)
        {
            case VariableReferenceType.Constant: return value;
            case VariableReferenceType.Variable: return component.GetValue();
            default: return value;
        }
    }

    public override VariableComponent<int> GetComponent()
    {
        return component;
    }
}
