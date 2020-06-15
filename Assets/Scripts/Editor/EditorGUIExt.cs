using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

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

    public static void TagSelector(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.String)
        {
            List<string> tagList = new List<string>();

            EditorGUI.BeginProperty(position, label, property);

            // Setup the tag list
            tagList.Clear();
            tagList.Add("<NoTag>");
            tagList.AddRange(UnityEditorInternal.InternalEditorUtility.tags);

            // Get the current value of the 
            string currentValue = property.stringValue;
            int popupIndex = -1;

            // Find out where the current value is in the list of tags
            if (currentValue.Equals(""))
            {
                popupIndex = 0;
            }
            else
            {
                popupIndex = tagList.FindIndex(1, x => x == currentValue);
            }

            // Do the popup
            popupIndex = EditorGUI.Popup(position, popupIndex, tagList.ToArray());

            // Read the result of the popup back into the property
            if (popupIndex == 0) property.stringValue = "";
            else if (popupIndex >= 1) property.stringValue = tagList[popupIndex];
            else property.stringValue = "";

            EditorGUI.EndProperty();
        }
        else EditorGUI.PropertyField(position, property);
    }
}
