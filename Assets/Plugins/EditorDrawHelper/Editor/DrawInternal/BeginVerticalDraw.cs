using System;
using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class BeginVerticalDraw
    {
        public static void Draw(GUIStyle style = null, GUILayoutOption[] options = null)
        {
            if (options == null)
            {
                BeginVertical(style);
            }
            else
            {
                BeginVertical(style, options);
            }
        }

        private static void BeginVertical(GUIStyle style)
        {
            if (style == null)
            {
                EditorGUILayout.BeginVertical();
            }
            else
            {
                EditorGUILayout.BeginVertical(style);
            }
        }

        private static void BeginVertical(GUIStyle style, GUILayoutOption[] options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (options.Length == 0)
                throw new ArgumentNullException(nameof(options));

            if (style == null)
            {
                EditorGUILayout.BeginVertical(options);
            }
            else
            {
                EditorGUILayout.BeginVertical(style, options);
            }
        }
    }
}
