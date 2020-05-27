using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public abstract class EventComponent<Arg> : MonoBehaviour
{
    public abstract string GetName();
    public abstract UnityEvent<Arg> GetEvent();

    public void Invoke(Arg arg)
    {
        UnityEvent<Arg> unityEvent = GetEvent();

        if(unityEvent != null)
        {
            unityEvent.Invoke(arg);
        }
    }
}
