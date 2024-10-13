using UnityEngine;

namespace Services.Input
{
    public abstract class InputService : IInputService
    {
        protected const string horizontal = "Horizontal";
        protected const string vertical = "Vertical";
        private const string button = "Fire";
        public abstract Vector2 Axis { get; }
        public bool IsAttackButtonUp() => SimpleInput.GetButtonUp(button);

        protected Vector2 SimpleInputAxis() => 
            new(SimpleInput.GetAxis(horizontal), SimpleInput.GetAxis(vertical));
    }
}