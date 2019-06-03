using System;

namespace EditorDraw
{
    internal static class InvokeDraw
    {
        public static void Draw(Action action)
        {
            action.Invoke();
        }
    }
}
