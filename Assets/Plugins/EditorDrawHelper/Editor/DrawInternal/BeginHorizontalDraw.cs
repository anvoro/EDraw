using System;
using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class BeginHorizontalDraw
    {
        public static void Draw(GUIStyle style = null, GUILayoutOption[] options = null)
        {
            if (options == null)
            {
                BeginHorizontal(style);
            }
            else
            {
                BeginHorizontal(style, options);
            }
        }

        private static void BeginHorizontal(GUIStyle style)
        {
            if (style == null)
            {
                EditorGUILayout.BeginHorizontal();
            }
            else
            {
                EditorGUILayout.BeginHorizontal(style);
            }
        }

        private static void BeginHorizontal(GUIStyle style, GUILayoutOption[] options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (options.Length == 0)
                throw new ArgumentNullException(nameof(options));

            if (style == null)
            {
                EditorGUILayout.BeginHorizontal(options);
            }
            else
            {
                EditorGUILayout.BeginHorizontal(style, options);
            }
        }
    }
}
