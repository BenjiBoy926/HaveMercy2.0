using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

//Original by DYLAN ENGELMAN http://jupiterlighthousestudio.com/custom-inspectors-unity/
//Altered by Brecht Lecluyse http://www.brechtos.com

[CustomPropertyDrawer(typeof(TagSelectorAttribute))]
public class TagSelectorPropertDrawer : PropertyDrawer
{
    List<string> tagList = new List<string>();

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        TagSelectorAttribute attribute = this.attribute as TagSelectorAttribute;

        if(attribute.useDefaultDrawer)
        {
            EditorGUI.PropertyField(position, property);
        }
        else
        {
            EditorGUIExt.TagSelector(position, property, label);
        }
    }
}
