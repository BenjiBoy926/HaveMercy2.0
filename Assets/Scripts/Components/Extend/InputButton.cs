using UnityEngine;
using UnityEngine.Events;

public class InputButton : MonoBehaviour
{
    [SerializeField]
    private StringReference inputName;

    [SerializeField]
    private UnityEvent down;
    [SerializeField]
    private UnityEvent stay;
    [SerializeField]
    private UnityEvent up;

    private void Update()
    {
        if(Input.GetButtonDown(inputName.GetValue()))
        {
            down.Invoke();
        }
        if(Input.GetButton(inputName.GetValue()))
        {
            stay.Invoke();
        }
        if(Input.GetButtonUp(inputName.GetValue()))
        {
            up.Invoke();
        }
    }
}
