using UnityEngine;
using UnityEditor;

public class EditorReferenceDrawer
{
    public static void OnGUI(Rect position, SerializedProperty property, GUIContent label, ref bool foldout)
    {
        foldout = EditorGUI.BeginFoldoutHeaderGroup(EditorGUIExt.ChildPropertyRect(position, 0), foldout, label);

        if (foldout)
        {
            SerializedProperty type = property.FindPropertyRelative("type");
            SerializedProperty component = property.FindPropertyRelative("component");
            SerializedProperty value = property.FindPropertyRelative("value");

            EditorGUI.indentLevel = 1;
            EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 1), type);

            switch (type.enumValueIndex)
            {
                case 0:
                    EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), value);
                    break;
                case 1:
                    EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), component);
                    break;
                default:
                    EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), value);
                    break;
            }
        }

        EditorGUI.EndFoldoutHeaderGroup();
    }

    public static float GetPropertyHeight(SerializedProperty property, GUIContent label, bool foldout)
    {
        if (foldout)
        {
            return EditorGUIExt.GetControlHeight(3);
        }
        else
        {
            return EditorGUIExt.GetControlHeight(1);
        }
    }
}