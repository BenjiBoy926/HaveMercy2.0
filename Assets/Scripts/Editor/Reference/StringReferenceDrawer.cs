using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(StringReference))]
public class StringReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorReferenceDrawer.OnGUI(position, property, label, ValueDrawer);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorReferenceDrawer.GetPropertyHeight(property, label);
    }

    private void ValueDrawer(Rect position, SerializedProperty value)
    {
        value.stringValue = EditorGUI.TextField(position, value.stringValue);
    }
}
