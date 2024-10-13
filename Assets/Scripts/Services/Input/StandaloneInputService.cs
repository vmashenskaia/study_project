using UnityEngine;

namespace Services.Input
{
    public class StandaloneInputService : InputService
    {
        public override Vector2 Axis {
            get
            {
                Vector2 axis = SimpleInputAxis();
                if (axis == Vector2.zero)
                {
                    axis = UnityAxis();
                }

                return axis;
            }
        }

        private Vector2 UnityAxis() => 
            new(UnityEngine.Input.GetAxis(horizontal), UnityEngine.Input.GetAxis(vertical));
    }
}