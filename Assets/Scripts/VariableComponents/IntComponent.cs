using UnityEngine;
using UnityEngine.Events;

public class IntComponent : VariableComponent<int>
{
    // VARIABLES
    [SerializeField]
    [Tooltip("The name of the variable this component represents")]
    private string variableName;

    [SerializeField]
    [Tooltip("The default value of the variable component")]
    private int defaultValue;

    [SerializeField]
    [Tooltip("Event invoked when the value of the component changes")]
    private ValueUpdateIntEventComponent onValueChanged;

    // FUNCITONS

    // Override getters
    public override string GetName()
    {
        return variableName;
    }
    public override int GetDefaultValue()
    {
        return defaultValue;
    }
    public override EventComponent<ValueUpdate<int>> GetValueChangedEvent()
    {
        return onValueChanged;
    }

    private void Start()
    {
        value = defaultValue;
    }
}
