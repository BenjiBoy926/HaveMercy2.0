using UnityEngine;
using System.Collections.Generic;

public class ChangeOnCollider2DEvent : MonoBehaviour
{
    [SerializeField]
    private Collider2DEventComponent eventComponent;

    [SerializeField]
    [Tooltip("Integer to change when the collider event is raised")]
    private IntVariable intComponent;

    [SerializeField]
    [Tooltip("Amount to change the int component by when the event is raised with a matching collider")]
    private int change;

    [SerializeField]
    private TagSearchCriteria criteria;

    private void Awake()
    {
        eventComponent.GetEvent().AddListener(CheckAndChange);
    }

    private void CheckAndChange(Collider2D collider)
    {
        if(TagManager.TagCheck(criteria, collider.tag))
        {
            intComponent.SetValue(intComponent.GetValue() + change);
        }
    }
}
