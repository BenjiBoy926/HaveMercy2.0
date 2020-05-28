using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(IntReference))]
public class IntReferenceDrawer : PropertyDrawer
{
    private bool foldout = false;   // True if the drawer is unfurled

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        foldout = EditorGUI.BeginFoldoutHeaderGroup(EditorGUIExtension.ChildPropertyRect(position, 0), foldout, label);

        if(foldout)
        {
            SerializedProperty type = property.FindPropertyRelative("type");
            SerializedProperty component = property.FindPropertyRelative("component");
            SerializedProperty value = property.FindPropertyRelative("value");

            EditorGUI.indentLevel = 1;
            EditorGUI.PropertyField(EditorGUIExtension.ChildPropertyRect(position, 1), type);

            switch(type.enumValueIndex)
            {
                case 0:
                    EditorGUI.PropertyField(EditorGUIExtension.ChildPropertyRect(position, 2), value);
                    break;
                case 1:
                    EditorGUI.PropertyField(EditorGUIExtension.ChildPropertyRect(position, 2), component);
                    break;
                default:
                    EditorGUI.PropertyField(EditorGUIExtension.ChildPropertyRect(position, 2), value);
                    break;
            }
        }

        EditorGUI.EndFoldoutHeaderGroup();
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if(foldout)
        {
            return EditorGUIExtension.GetControlHeight(3);
        }
        else
        {
            return EditorGUIExtension.GetControlHeight(1);
        }
    }
}
