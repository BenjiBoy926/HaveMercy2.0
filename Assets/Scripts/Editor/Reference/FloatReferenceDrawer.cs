using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(FloatReference))]
public class FloatReferenceDrawer : PropertyDrawer
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
        value.floatValue = EditorGUI.FloatField(position, value.floatValue);
    }
}
