using UnityEngine;
using UnityEditor;
using System.Collections;

public static class EditorGUIExt
{
    // Get the rect of a single control, given the rect of the parent control
    // and the index of the control inside the parent control
    public static Rect ChildPropertyRect(Rect parentRect, int index)
    {
        return new Rect(
            parentRect.x, 
            parentRect.y + index * (EditorGUIUtility.standardVerticalSpacing + EditorGUIUtility.singleLineHeight), 
            parentRect.width, 
            EditorGUIUtility.singleLineHeight);
    }

    public static float GetControlHeight(int subControls)
    {
        return subControls * (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing);
    }
}
