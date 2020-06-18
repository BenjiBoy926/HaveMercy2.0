using UnityEngine;
using UnityEditor;

public class EditorReferenceDrawer
{
    public static void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUIExt.BasicSwitchDrawer(position, property, label, 90f, "type", "value", "component");
    }

    public static float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
    }
}