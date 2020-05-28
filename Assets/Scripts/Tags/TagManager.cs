using UnityEngine;
using System.Collections.Generic;

public class TagManager
{
    public static bool TagCheck(TagSearchCriteria criteria, string tag)
    {
        return TagCheck(criteria.tags, criteria.check, tag);
    }

    public static bool TagCheck(List<string> tagsToCheck, TagCheckType check, string tag)
    {
        if (check == TagCheckType.Any)
        {
            foreach (string t in tagsToCheck)
            {
                if (tag.Contains(t))
                {
                    return true;
                }
            }
            return false;
        }
        else
        {
            bool hasAllTags = true;
            foreach (string t in tagsToCheck)
            {
                hasAllTags &= tag.Contains(t);
            }
            return hasAllTags;
        }
    }
}
