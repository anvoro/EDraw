using System;
using UnityEngine;

namespace EditorDraw
{
    public static partial class EDraw
    {
        public static IDraw Button(this IDraw draw,
            string buttonText,
            Action buttonAction,
            GUIStyle style = null,
            Color? color = null,
            bool lossFocus = false,
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

            ButtonDraw.Draw(buttonText, buttonAction, style, opts, color, lossFocus);

            return draw;
        }

        public static IDraw S_Button(this IDraw draw,
            string buttonText,
            Action buttonAction,
            GUIStyle style = null,
            Color? color = null,
            bool lossFocus = false)
        {
            ButtonDraw.Draw(buttonText, buttonAction, style, null, color, lossFocus);

            return draw;
        }

        public static IDraw TextField(this IDraw draw,
            ref string text,
            string label = null,
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

            TextFieldDraw.Draw(ref text, label, style, opts);

            return draw;
        }

        public static IDraw S_TextField(this IDraw draw,
            ref string text,
            string label = null,
            GUIStyle style = null)
        {
            TextFieldDraw.Draw(ref text, label, style, null);

            return draw;
        }

        public static IDraw DrawEnumPopup<TEnum>(this IDraw draw,
            ref TEnum @enum,
            string label = null,
            GUIStyle style = null,
            float? height = null,
            float? maxHeight = null,
            float? minHeight = null,
            bool? expandHeight = null,
            float? width = null,
            float? maxWidth = null,
            float? minWidth = null,
            bool? expandWidth = null)
            where TEnum : struct, IConvertible
        {
            var opts = LayoutOptionsCache.ExtractLayoutOptions(height,
                maxHeight,
                minHeight,
                expandHeight,
                width,
                maxWidth,
                minWidth,
                expandWidth);

            EnumPopupDraw.Draw(ref @enum, label, style, opts);

            return draw;
        }

        public static IDraw S_DrawEnumPopup<TEnum>(this IDraw draw,
            ref TEnum @enum,
            string label = null,
            GUIStyle style = null)
            where TEnum : struct, IConvertible
        {
            EnumPopupDraw.Draw(ref @enum, label, style, null);

            return draw;
        }

        public static IDraw DrawStringsPopup(this IDraw draw,
            ref int selectedIndex,
            string[] displayedStrings,
            string label = null,
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

            StringsPopupDraw.Draw(ref selectedIndex, displayedStrings, label, style, opts);

            return draw;
        }

        public static IDraw S_DrawStringsPopup(this IDraw draw,
            ref int selectedIndex,
            string[] displayedStrings,
            string label = null,
            GUIStyle style = null)
        {
            StringsPopupDraw.Draw(ref selectedIndex, displayedStrings, label, style, null);

            return draw;
        }
    }
}
