using System;
using System.Collections.Generic;
using UnityEngine;

namespace EditorDraw
{
    internal class LayoutOptionsBuilder
    {
        private enum BuilderState
        {
            Active = 1,

            Built = 2,

            Stopped = 3
        }

        private readonly List<GUILayoutOption> _options = new List<GUILayoutOption>(8);

        private GUILayoutOption[] _result;

        private BuilderState _state;

        public LayoutOptionsBuilder()
        {
            this._state = BuilderState.Stopped;
        }

        public GUILayoutOption[] GetResult()
        {
            this.CheckStateIsBuilt();

            return this._result;
        }

        public void Start()
        {
            this._state = BuilderState.Active;
            this._options.Clear();
        }

        public void Build()
        {
            this.CheckStateIsActive();

            if (this._options.Count == 0)
            {
                this._result = null;
            }
            else
            {
                this._result = this._options.ToArray();
            }

            this._state = BuilderState.Built;
        }

        private void CheckStateIsActive()
        {
            if (this._state != BuilderState.Active)
                throw new InvalidOperationException("Incorrect Builder state");
        }

        private void CheckStateIsBuilt()
        {
            if (this._state != BuilderState.Built)
                throw new InvalidOperationException("Incorrect Builder state");
        }

        public void SetHeight(float height)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.Height(height));
        }

        public void SetMaxHeight(float maxHeight)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.MaxHeight(maxHeight));
        }

        public void SetMinHeight(float minHeight)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.MinHeight(minHeight));
        }

        public void SetExpandHeight(bool expandHeight)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.ExpandHeight(expandHeight));
        }

        public void SetWidth(float width)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.Width(width));
        }

        public void SetMaxWidth(float maxWidth)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.MaxWidth(maxWidth));
        }

        public void SetMinWidth(float minWidth)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.MinWidth(minWidth));
        }

        public void SetExpandWidth(bool expandWidth)
        {
            this.CheckStateIsActive();

            this._options.Add(GUILayout.ExpandWidth(expandWidth));
        }
    }
}
