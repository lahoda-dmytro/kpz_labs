using System;

namespace ClassLibrary
{
    public interface IElementState
    {
        void HandleDisplay(LightElementNode element);
        void HandleVisibility(LightElementNode element);
    }

    public class VisibleState : IElementState
    {
        public void HandleDisplay(LightElementNode element)
        {
            element.Display = DisplayType.Block;
            element.OnStylesApplied();
        }

        public void HandleVisibility(LightElementNode element)
        {
            element.AddClass("visible");
            element.OnClassListApplied();
        }
    }

    public class HiddenState : IElementState
    {
        public void HandleDisplay(LightElementNode element)
        {
            element.Display = DisplayType.None;
            element.OnStylesApplied();
        }

        public void HandleVisibility(LightElementNode element)
        {
            element.AddClass("hidden");
            element.OnClassListApplied();
        }
    }

    public class InlineState : IElementState
    {
        public void HandleDisplay(LightElementNode element)
        {
            element.Display = DisplayType.Inline;
            element.OnStylesApplied();
        }

        public void HandleVisibility(LightElementNode element)
        {
            element.AddClass("inline");
            element.OnClassListApplied();
        }
    }

    // Extension of LightElementNode to support state
    public partial class LightElementNode
    {
        private IElementState currentState;

        public void SetState(IElementState state)
        {
            currentState = state;
            currentState.HandleDisplay(this);
            currentState.HandleVisibility(this);
        }
    }
} 