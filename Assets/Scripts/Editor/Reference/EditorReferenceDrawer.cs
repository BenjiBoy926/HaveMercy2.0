using UnityEngine;
using UnityEditor;
using System;

public class EditorReferenceDrawer
{
    public static void OnGUI(Rect position, SerializedProperty property, GUIContent label, Action<Rect, SerializedProperty> valueDrawer)
    {
        Rect content = EditorGUI.PrefixLabel(position, label);

        // Calculate the content for the reference button toggle and the reference drawer
        float typeWidth = content.width * 0.3f;
        Rect typeRect = new Rect(content.x, content.y, typeWidth, content.height);
        Rect valueRect = new Rect(content.x + typeWidth, content.y, content.width - typeWidth, content.height);

        SerializedProperty type = property.FindPropertyRelative("type");
        SerializedProperty reference = property.FindPropertyRelative("component");
        SerializedProperty value = property.FindPropertyRelative("value");
        
        type.enumValueIndex = (int)(ReferenceType)EditorGUI.EnumPopup(typeRect, (ReferenceType)type.enumValueIndex);

        if(type.enumValueIndex == 0)
        {
            valueDrawer.Invoke(valueRect, value);
        }
        else
        {
            EditorGUI.ObjectField(valueRect, reference, GUIContent.none);
        }


        //foldout = EditorGUI.BeginFoldoutHeaderGroup(EditorGUIExt.ChildPropertyRect(position, 0), foldout, label);

        //if (foldout)
        //{
        //    SerializedProperty type = property.FindPropertyRelative("type");
        //    SerializedProperty component = property.FindPropertyRelative("component");
        //    SerializedProperty value = property.FindPropertyRelative("value");

        //    EditorGUI.indentLevel = 1;
        //    EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 1), type);

        //    switch (type.enumValueIndex)
        //    {
        //        case 0:
        //            EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), value);
        //            break;
        //        case 1:
        //            EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), component);
        //            break;
        //        default:
        //            EditorGUI.PropertyField(EditorGUIExt.ChildPropertyRect(position, 2), value);
        //            break;
        //    }
        //}

        //EditorGUI.EndFoldoutHeaderGroup();
    }

    public static float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
    }
}