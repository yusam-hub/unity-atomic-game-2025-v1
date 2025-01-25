using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame.Common
{
    public static class InputUseCase
    {
        public static bool IsJump(in IPlayerContext context)
        {
            KeyCode keyCode = context.GetInputMap().Jump;
            return Input.GetKeyDown(keyCode);
        }

        public static Vector3 GetMoveDirection(in IPlayerContext context)
        {
            InputMap inputMap = context.GetInputMap();

            if (Input.GetKey(inputMap.MoveForward))
                return Vector3.forward;

            if (Input.GetKey(inputMap.MoveBack))
                return Vector3.back;

            if (Input.GetKey(inputMap.MoveLeft))
                return Vector3.left;

            if (Input.GetKey(inputMap.MoveRight))
                return Vector3.right;

            return Vector3.zero;
        }
    }
}