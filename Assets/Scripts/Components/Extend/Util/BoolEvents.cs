using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct BoolEvents
{
    [SerializeField]
    [Tooltip("Event invoked on return true")]
    public UnityEvent _true;
    [SerializeField]
    [Tooltip("Event invoked on false")]
    public UnityEvent _false;
}
