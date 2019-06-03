using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class TextFieldDraw
    {
        public static void Draw(ref string text, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (!string.IsNullOrEmpty(label))
            {
                text = TextField(text, label, style, options);
            }
            else
            {
                text = TextFieldWithoutLabel(text, style, options);
            }
        }

        private static string TextField(string text, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return EditorGUILayout.TextField(label, text);
            }

            if (style != null && options == null)
            {
                return EditorGUILayout.TextField(label, text, style);
            }

            if (style == null)
            {
                return EditorGUILayout.TextField(label, text, options);
            }

            return EditorGUILayout.TextField(label, text, style, options);
        }

        private static string TextFieldWithoutLabel(string text, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return EditorGUILayout.TextField(text);
            }

            if (style != null && options == null)
            {
                return EditorGUILayout.TextField(text, style);
            }

            if (style == null)
            {
                return EditorGUILayout.TextField(text, options);
            }

            return EditorGUILayout.TextField(text, style, options);
        }
    }
}
