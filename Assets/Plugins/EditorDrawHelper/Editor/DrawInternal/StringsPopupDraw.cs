using UnityEditor;
using UnityEngine;

namespace EditorDraw
{
    internal static class StringsPopupDraw
    {
        public static void Draw(ref int selectedIndex, string[] displayedStrings, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (!string.IsNullOrEmpty(label))
            {
                selectedIndex = Popup(selectedIndex, displayedStrings, label, style, options);
            }
            else
            {
                selectedIndex = PopupWithoutLabel(selectedIndex, displayedStrings, style, options);
            }
        }

        private static int Popup(int selectedIndex, string[] displayedStrings, string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return EditorGUILayout.Popup(label, selectedIndex, displayedStrings);
            }

            if (style != null && options == null)
            {
                return EditorGUILayout.Popup(label, selectedIndex, displayedStrings, style);
            }

            if (style == null)
            {
                return EditorGUILayout.Popup(label, selectedIndex, displayedStrings, options);
            }

            return EditorGUILayout.Popup(label, selectedIndex, displayedStrings, style, options);
        }

        private static int PopupWithoutLabel(int selectedIndex, string[] displayedStrings, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                return EditorGUILayout.Popup(selectedIndex, displayedStrings);
            }

            if (style != null && options == null)
            {
                return EditorGUILayout.Popup(selectedIndex, displayedStrings, style);
            }

            if (style == null)
            {
                return EditorGUILayout.Popup(selectedIndex, displayedStrings, options);
            }

            return EditorGUILayout.Popup(selectedIndex, displayedStrings, style, options);
        }
    }
}
