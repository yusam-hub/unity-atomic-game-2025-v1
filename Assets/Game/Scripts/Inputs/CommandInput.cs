using UnityEngine;

namespace Game
{
    public sealed class CommandInput : ICommandInput
    {
        public bool IsMoveRequired => Input.GetMouseButtonDown(1);
        public Vector2 MousePosition => Input.mousePosition;
    }
}