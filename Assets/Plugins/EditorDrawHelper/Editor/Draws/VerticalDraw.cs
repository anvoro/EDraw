using UnityEngine;

namespace EditorDraw
{
    public static partial class EDraw
    {
        public static IDraw BeginVertical(this IDraw draw,
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

            BeginVerticalDraw.Draw(style, opts);

            return draw;
        }

        public static IDraw S_BeginVertical(this IDraw draw,
            GUIStyle style = null)
        {
            BeginVerticalDraw.Draw(style);

            return draw;
        }

        public static IDraw EndVertical(this IDraw draw)
        {
            EndVerticalDraw.Draw();

            return draw;
        }
    }
}
