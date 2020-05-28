using UnityEngine;
using System.Collections;

public class DestroyOtherOnCollider2DEvent : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Event raised by the Collider 2D")]
    private Collider2DEventComponent eventComponent;

    [SerializeField]
    private TagSearchCriteria criteria;

    private void Awake()
    {
        eventComponent.GetEvent().AddListener(
            other =>
            {
                if(TagManager.TagCheck(criteria, other.tag))
                {
                    Destroy(other.gameObject);
                }
            });
    }
}
