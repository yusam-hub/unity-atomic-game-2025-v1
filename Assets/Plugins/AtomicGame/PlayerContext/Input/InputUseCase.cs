using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public static class InputUseCase
    {
        public static bool IsJump(in IPlayerContext context)
        {
            KeyCode keyCode = context.GetInputMap().Jump;
            return Input.GetKeyDown(keyCode);
        }
        
        public static bool IsJumpPress(in IPlayerContext context)
        {
            KeyCode keyCode = context.GetInputMap().Jump;
            return Input.GetKey(keyCode);
        }

        public static bool IsInteract(in IPlayerContext context)
        {
            KeyCode keyCode = context.GetInputMap().Interact;
            return Input.GetKeyDown(keyCode);
        }
        
        public static bool IsPause(in IPlayerContext context)
        {
            KeyCode keyCode = context.GetInputMap().Pause;
            return Input.GetKeyDown(keyCode);
        }
        
        public static Vector3 GetMoveDirection(in IPlayerContext context)
        {
            InputMap inputMap = context.GetInputMap();
            
            Vector3 direction = Vector3.zero;
            
            if (Input.GetKey(inputMap.MoveForward))
                direction.z = 1;

            if (Input.GetKey(inputMap.MoveBack))
                direction.z = -1;

            if (Input.GetKey(inputMap.MoveLeft))
                direction.x = -1;

            if (Input.GetKey(inputMap.MoveRight))
                direction.x = 1;;

            return direction.normalized;
        }
    }
}