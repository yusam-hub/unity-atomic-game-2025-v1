using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame.Common
{
    public static class AgAnimatorUseCase
    {
        private static readonly int IdleDefaultKey = Animator.StringToHash("IdleDefault");
        private static readonly int MoveDefaultKey = Animator.StringToHash("MoveDefault");
        private static readonly int JumpingDefaultKey = Animator.StringToHash("JumpingDefault");
        
        public static void AgHumanAnimatorChangeCrossFadeEventLateUpdate(this IEntity entity, float deltaTime)
        {
            if (!entity.HasAnimator()) return;
            if (!entity.HasIsMoving()) return;
            if (!entity.HasIsGrounded()) return;

            if (entity.GetIsGrounded().Value)
            {
                if (entity.GetIsMoving().Value)
                {
                    entity.GetChangeCrossFadeEvent().Invoke(MoveDefaultKey); 
                }
                else
                {
                    entity.GetChangeCrossFadeEvent().Invoke(IdleDefaultKey);
                }
            }
            else
            {
                entity.GetChangeCrossFadeEvent().Invoke(JumpingDefaultKey);
            }
        }
    }
}