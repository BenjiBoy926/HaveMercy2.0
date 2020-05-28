using UnityEngine;
using System.Collections;

public struct ValueUpdate<Type>
{
    public Type oldValue;
    public Type newValue;

    public ValueUpdate(Type oldVal, Type newVal)
    {
        oldValue = oldVal;
        newValue = newVal;
    } 
}
