using UnityEngine;

namespace EditorDraw
{
    internal static class LabelDraw
    {
        public static void Draw(string label, GUIStyle style, GUILayoutOption[] options)
        {
            if (style == null && options == null)
            {
                GUILayout.Label(label);
            }
            else if (style != null && options == null)
            {
                GUILayout.Label(label, style);
            }
            else if (style == null)
            {
                GUILayout.Label(label, options);
            }
            else
            {
                GUILayout.Label(label, style, options);
            }
        }
    }
}
