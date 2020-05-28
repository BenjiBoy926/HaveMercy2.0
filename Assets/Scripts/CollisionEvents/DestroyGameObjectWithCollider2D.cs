using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjectWithCollider2D : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Check the tags on the collider in this event")]
    private Collider2DEventComponent eventComponent;

    [SerializeField]
    [Tooltip("Check the game object for any tag, or for all tags")]
    private TagSearchCriteria tagSearchCriteria;

    private void Awake()
    {
        eventComponent.GetEvent().AddListener(DestroyGameObject);
    }

    private void DestroyGameObject(Collider2D collider)
    {
        if(TagManager.TagCheck(tagSearchCriteria, collider.tag))
        {
            Destroy(collider.gameObject);
        }
    }
}
