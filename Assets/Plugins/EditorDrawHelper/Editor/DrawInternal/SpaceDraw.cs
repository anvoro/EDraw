using UnityEngine;

namespace EditorDraw
{
    internal static class SpaceDraw
    {
        public static void Draw(float pixels)
        {
            GUILayout.Space(pixels);
        }
    }
}
