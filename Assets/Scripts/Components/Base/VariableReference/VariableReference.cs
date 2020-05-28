using UnityEngine;
using System.Collections;

[System.Serializable]
public abstract class VariableReference<Type>
{
    public abstract Type GetValue();
    public abstract VariableComponent<Type> GetComponent();
}
