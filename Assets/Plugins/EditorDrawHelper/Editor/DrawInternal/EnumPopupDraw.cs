using System;
using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class EnumPopupDraw
    {
        public static void Draw<TEnum>(ref TEnum @enum, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (!string.IsNullOrEmpty(label))
            {
                @enum = (TEnum)EnumPopup(@enum, label, style, options);
            }
            else
            {
                @enum = (TEnum)EnumPopupWithoutLabel(@enum, style, options);
            }
        }

        private static object EnumPopup<TEnum>(TEnum @enum, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return EditorGUILayout.EnumPopup(label, (Enum)(object)@enum);
            }

            if (style != null && options == null)
            {
                return (TEnum)(object)EditorGUILayout.EnumPopup(label, (Enum)(object)@enum, style);
            }

            if (style == null)
            {
                return (TEnum)(object)EditorGUILayout.EnumPopup(label, (Enum)(object)@enum, options);
            }

            return (TEnum)(object)EditorGUILayout.EnumPopup(label, (Enum)(object)@enum, style, options);
        }

        private static object EnumPopupWithoutLabel<TEnum>(TEnum @enum, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return (TEnum)(object)EditorGUILayout.EnumPopup((Enum)(object)@enum);
            }

            if (style != null && options == null)
            {
                return (TEnum)(object)EditorGUILayout.EnumPopup((Enum)(object)@enum, style);
            }

            if (style == null)
            {
                return (TEnum)(object)EditorGUILayout.EnumPopup((Enum)(object)@enum, options);
            }

            return (TEnum)(object)EditorGUILayout.EnumPopup((Enum)(object)@enum, style, options);
        }
    }
}
