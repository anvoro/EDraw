using System;
using UnityEngine;

namespace EditorDraw
{
    public static partial class EDraw
    {
        public interface IDraw {}

        internal class DrawMock : IDraw { }

        private static readonly DrawMock mock = new DrawMock();

        public static IDraw BeginDraw()
        {
            return mock;
        }

        public static IDraw DrawLabel(this IDraw draw,
            string label,
            GUIStyle style,
            float? height = null,
            float? maxHeight = null,
            float? minHeight = null,
            bool? expandHeight = null,
            float? width = null,
            float? maxWidth = null,
            float? minWidth = null,
            bool? expandWidth = null)
        {
            if (label == null)
                throw new ArgumentNullException(nameof(label));

            var opts = LayoutOptionsCache.ExtractLayoutOptions(height,
                maxHeight,
                minHeight,
                expandHeight,
                width,
                maxWidth,
                minWidth,
                expandWidth);

            LabelDraw.Draw(label, style, opts);

            return draw;
        }

        public static IDraw S_DrawLabel(this IDraw draw,
            string label,
            GUIStyle style = null)
        {
            if (label == null)
                throw new ArgumentNullException(nameof(label));

            LabelDraw.Draw(label, style, null);

            return draw;
        }

        public static IDraw DrawSpace(this IDraw draw, float pixels = 4)
        {
            SpaceDraw.Draw(pixels);

            return draw;
        }

        public static IDraw Invoke(this IDraw draw, Action action)
        {
            InvokeDraw.Draw(action);

            return draw;
        }
    }
}
