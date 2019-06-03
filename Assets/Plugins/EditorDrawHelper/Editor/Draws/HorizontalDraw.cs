using UnityEngine;

namespace EditorDraw
{
    public static partial class EDraw
    {
        public static IDraw BeginHorizontal(this IDraw draw,
            GUIStyle style = null,
            float? height = null,
            float? maxHeight = null,
            float? minHeight = null,
            bool? expandHeight = null,
            float? width = null,
            float? maxWidth = null,
            float? minWidth = null,
            bool? expandWidth = null)
        {
            var opts = LayoutOptionsCache.ExtractLayoutOptions(height,
                maxHeight,
                minHeight,
                expandHeight,
                width,
                maxWidth,
                minWidth,
                expandWidth);

            BeginHorizontalDraw.Draw(style, opts);

            return draw;
        }

        public static IDraw S_BeginHorizontal(this IDraw draw,
            GUIStyle style = null)
        {
            BeginHorizontalDraw.Draw(style);

            return draw;
        }

        public static IDraw EndHorizontal(this IDraw draw)
        {
            EndHorizontalDraw.Draw();

            return draw;
        }
    }
}
