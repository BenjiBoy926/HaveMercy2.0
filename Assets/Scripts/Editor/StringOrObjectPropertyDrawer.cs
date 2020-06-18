using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer(typeof(StringOrObject))]
public class StringOrObjectPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUIExt.BasicSwitchDrawer(position, property, label, 80f, "type", "str", "obj");
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
}
