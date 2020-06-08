using UnityEngine;

public class CompareTag : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Reference to the event component that triggers this event")]
    private GameObjectReference gameObjectReference;

    [SerializeField]
    [Tooltip("Criteria that the game object tag is checked against")]
    private TagSearchCriteria criteria;

    [SerializeField]
    [Tooltip("Events invoked after the tag is checked")]
    private BoolEvents events;

    public void Compare()
    {
        if(TagManager.TagCheck(criteria, gameObjectReference.GetValue().tag))
        {
            events._true.Invoke();
        }
        else
        {
            events._false.Invoke();
        }
    }
}
