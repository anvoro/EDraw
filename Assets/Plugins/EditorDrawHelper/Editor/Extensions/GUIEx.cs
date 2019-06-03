using UnityEngine;

namespace EditorDraw
{
    public static class GUIEx
    {
        public static GUIStyle LabelStyle(FontStyle fontStyle, TextAnchor alignment = TextAnchor.MiddleLeft)
        {
            GUIStyle labelStyle = new GUIStyle(GUI.skin.label)
            {
                fontStyle = fontStyle,
                alignment = alignment
            };

            return labelStyle;
        }
    }
}
