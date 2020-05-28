using UnityEngine;
using UnityEngine.Events;

public class FloatComponent : VariableComponent<float>
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
    private ValueUpdateFloatEventComponent onValueChanged;

    // FUNCITONS

    // Override getters
    public override string GetName()
    {
        return variableName;
    }
    public override float GetDefaultValue()
    {
        return defaultValue;
    }
    public override EventComponent<ValueUpdate<float>> GetValueChangedEvent()
    {
        return onValueChanged;
    }

    private void Start()
    {
        value = defaultValue;
    }
}
