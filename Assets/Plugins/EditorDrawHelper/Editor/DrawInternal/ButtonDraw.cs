using System;
using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class ButtonDraw
    {
        public static void Draw(
            string buttonText,
            Action buttonAction,
            GUIStyle style,
            GUILayoutOption[] options,
            Color? color,
            bool lossFocus)
        {
            if (buttonAction == null)
                throw new ArgumentNullException(nameof(buttonAction));

            if (DrawButtonInternal(buttonText, style, options, color))
            {
                buttonAction?.Invoke();
                if (lossFocus)
                    GUI.FocusControl(null);
            }
        }

        private static bool DrawButtonInternal(
            string buttonText,
            GUIStyle style,
            GUILayoutOption[] options,
            Color? color)
        {
            bool result;
            Color prevAddComponenButtonColor = GUI.color;

            if (color.HasValue)
            {
                EditorGUILayout.BeginHorizontal();
                GUI.color = color.Value;
            }

            if (style == null && options == null)
            {
                result = GUILayout.Button(buttonText);
            }
            else if(style != null && options == null)
            {
                result = GUILayout.Button(buttonText, style);
            }
            else if (style == null)
            {
                result = GUILayout.Button(buttonText, options);
            }
            else
            {
                result = GUILayout.Button(buttonText, style, options);
            }

            if (color.HasValue)
            {
                GUI.color = prevAddComponenButtonColor;
                EditorGUILayout.EndHorizontal();
            }

            return result;
        }
    }
}
