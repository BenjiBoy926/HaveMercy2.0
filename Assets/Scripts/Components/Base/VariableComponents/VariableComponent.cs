using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class VariableComponent<Type> : MonoBehaviour
{
    // VARIABLES
    protected Type value;

    // FUNCTIONS

    // Get/set the current value of the variable component
    public Type GetValue()
    {
        return value;
    }
    public void SetValue(Type newValue)
    {
        GetValueChangedEvent().Invoke(new ValueUpdate<Type>(value, newValue));
        value = newValue;
    }

    // Get the name.  Get the default value.  Get the value changed event
    // Abstract because each subclass needs to expose these in Unity's editor
    public abstract string GetName();
    public abstract Type GetDefaultValue();
    public abstract EventComponent<ValueUpdate<Type>> GetValueChangedEvent();
}
