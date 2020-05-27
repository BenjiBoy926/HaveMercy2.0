using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjectWithCollider2D : MonoBehaviour
{
    private enum TagCheck
    {
        Any, All
    }

    [SerializeField]
    [Tooltip("Check the tags on the collider in this event")]
    private Collider2DEventComponent eventComponent;

    [SerializeField]
    [Tooltip("Check the game object for any tag, or for all tags")]
    private TagCheck check;

    [SerializeField]
    [Tooltip("Tags to check against the game object")]
    private List<string> tags;

    private void Awake()
    {
        eventComponent.GetEvent().AddListener(DestroyGameObject);
    }

    private void DestroyGameObject(Collider2D collider)
    {
        if(check == TagCheck.Any)
        {
            foreach(string t in tags)
            {
                if(collider.tag.Contains(t))
                {
                    Destroy(collider.gameObject);
                    break;
                }
            }
        }
        else
        {
            bool hasAllTags = true;
            foreach (string t in tags)
            {
                hasAllTags &= collider.tag.Contains(t);
            }
            if (hasAllTags) Destroy(collider.gameObject);
        }
    }
}
