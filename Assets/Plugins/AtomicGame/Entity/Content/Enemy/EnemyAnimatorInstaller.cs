using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyAnimatorInstaller: SceneEntityInstaller
    {
        [SerializeField] 
        private AnimatorDispatcher _animatorDispatcher;

        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        public override void Install(IEntity entity)
        {
            entity.GetMoveDirection().Subscribe((value) =>
            {
                _animatorDispatcher.GetAnimator().SetBool(IsMoving, value != Vector3.zero);
            });
        }
    }
}