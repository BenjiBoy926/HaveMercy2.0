using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Vector2Reference))]
public class Vector2ReferenceDrawer : PropertyDrawer
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
        value.vector2Value = EditorGUI.Vector2Field(position, GUIContent.none, value.vector2Value);
    }
}
