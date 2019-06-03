using System.Collections.Generic;
using UnityEngine;

namespace EditorDraw
{
    internal static class LayoutOptionsCache
    {
        private static readonly LayoutOptionsBuilder optionsBuilder = new LayoutOptionsBuilder();

        private static readonly Dictionary<int, GUILayoutOption[]> cache = new Dictionary<int, GUILayoutOption[]>();

        public static GUILayoutOption[] ExtractLayoutOptions(
            float? height = null,
            float? maxHeight = null,
            float? minHeight = null,
            bool? expandHeight = null,
            float? width = null,
            float? maxWidth = null,
            float? minWidth = null,
            bool? expandWidth = null)
        {
            int hash = GetHash(
                height,
                maxHeight,
                minHeight,
                expandHeight,
                width,
                maxWidth,
                minWidth,
                expandWidth);

            if (hash < 0)
                return null;

            if (cache.ContainsKey(hash))
                return cache[hash];

            BuildOptions(
                height,
                maxHeight,
                minHeight,
                expandHeight,
                width, maxWidth,
                minWidth,
                expandWidth);

            GUILayoutOption[] options = optionsBuilder.GetResult();
            cache.Add(hash, options);

            return options;
        }

        private static void BuildOptions(float? height, float? maxHeight, float? minHeight, bool? expandHeight, float? width,
            float? maxWidth, float? minWidth, bool? expandWidth)
        {
            optionsBuilder.Start();

            if (height.HasValue)
                optionsBuilder.SetHeight(height.Value);

            if (maxHeight.HasValue)
                optionsBuilder.SetMaxHeight(maxHeight.Value);

            if (minHeight.HasValue)
                optionsBuilder.SetMinHeight(minHeight.Value);

            if (expandHeight.HasValue)
                optionsBuilder.SetExpandHeight(expandHeight.Value);

            if (width.HasValue)
                optionsBuilder.SetWidth(width.Value);

            if (maxWidth.HasValue)
                optionsBuilder.SetMaxWidth(maxWidth.Value);

            if (minWidth.HasValue)
                optionsBuilder.SetMinWidth(minWidth.Value);

            if (expandWidth.HasValue)
                optionsBuilder.SetExpandWidth(expandWidth.Value);

            optionsBuilder.Build();
        }

        private static int GetHash(
            float? height = null,
            float? maxHeight = null,
            float? minHeight = null,
            bool? expandHeight = null,
            float? width = null,
            float? maxWidth = null,
            float? minWidth = null,
            bool? expandWidth = null)
        {
            int hash = 17;

            if (height.HasValue)
                incrHashFloat(height.Value);

            if (maxHeight.HasValue)
                incrHashFloat(maxHeight.Value);

            if (minHeight.HasValue)
                incrHashFloat(minHeight.Value);

            if (expandHeight.HasValue)
                incrHashBool(expandHeight.Value);

            if (width.HasValue)
                incrHashFloat(width.Value);

            if (maxWidth.HasValue)
                incrHashFloat(maxWidth.Value);

            if (minWidth.HasValue)
                incrHashFloat(minWidth.Value);

            if (expandWidth.HasValue)
                incrHashBool(expandWidth.Value);

            return hash == 17 ? -1 : hash;

            void incrHashFloat(float value)
            {
                unchecked
                {
                    hash = hash * 23 + value.GetHashCode();
                }
            }

            void incrHashBool(bool value)
            {
                unchecked
                {
                    hash = hash * 23 + value.GetHashCode();
                }
            }
        }
    }
}
