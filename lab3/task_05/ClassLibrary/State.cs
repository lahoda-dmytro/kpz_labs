using System;

namespace ClassLibrary
{
    public interface IState
    {
        void HandleDisplay(LightElementNode element);
        void HandleVisibility(LightElementNode element);
    }

    public class VisibleState : IState
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

    public class HiddenState : IState
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

    public class InlineState : IState
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

    // розширення LightElementNode для підтримки станів
    public partial class LightElementNode
    {
        private IState currentState;

        public void SetState(IState state)
        {
            currentState = state;
            currentState.HandleDisplay(this);
            currentState.HandleVisibility(this);
        }
    }
} 