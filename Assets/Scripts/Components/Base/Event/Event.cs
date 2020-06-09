using UnityEngine;

public abstract class Event<InputType, ResultType> : MonoBehaviour
    where InputType : Inputs<int>
{
    public abstract void Do();

    
}
