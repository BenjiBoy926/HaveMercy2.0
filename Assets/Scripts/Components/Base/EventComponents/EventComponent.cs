using UnityEngine;
using UnityEngine.Events;
using System.Collections;

// An event component to be attached to a game object

// The typical way to handle an event is to expose the UnityEvent object in the editor
// and subscribe methods to it in the editor.  Pretty easy!  The problem is that the
// arguments passed to the UnityEvent cannot be passed to event listeners
// that are set up in the editor - they have to set it programmatically using AddListener()

// Exposing the UnityEvent and giving an interested class a reference to the class with
// the UnityEvent is hardly any trouble. In the short-term.  The problem is that a certain
// class may not really "care" WHERE the event is coming from.  And to give such a class a
// reference to a SPECIFIC class with a particular UnityEvent object would be a pretty 
// inflexible design

// To handle this, we decouple events from the script that invokes it, using event components
// Instead of asking the subscriber to go straight to the class with the event, it only needs
// to get a reference to the EventComponent that is also referenced by the invoking script

public abstract class EventComponent<Arg> : MonoBehaviour
{
    public abstract string GetName();
    public abstract UnityEvent<Arg> GetEvent();

    public void Invoke(Arg arg)
    {
        GetEvent()?.Invoke(arg);
    }
}
