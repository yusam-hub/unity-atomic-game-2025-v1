using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class CharacterAnimatorInstaller: SceneEntityInstaller
    {
        [SerializeField]
        private Animator _animator;

        private static readonly int IsGrounded = Animator.StringToHash("IsGrounded");
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private static readonly int DeathTrigger = Animator.StringToHash("DeathTrigger");

        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            
            entity.GetIsGrounded().Subscribe((value) =>
            {
                _animator.SetBool(IsGrounded, value);
            });
            
            entity.GetIsMoving().Subscribe((value) =>
            {
                _animator.SetBool(IsMoving, value);
            });

            entity.GetDeathEvent().Subscribe(() =>
            {
                _animator.SetTrigger(DeathTrigger);
            });
        }
    }
}