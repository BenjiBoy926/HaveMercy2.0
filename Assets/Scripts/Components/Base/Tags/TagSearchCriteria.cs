using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public struct TagSearchCriteria
{
    [Tooltip("Type to check for listed tags")]
    public TagCheckType check;
    [Tooltip("Tags to check for")]
    public List<string> tags;
}
