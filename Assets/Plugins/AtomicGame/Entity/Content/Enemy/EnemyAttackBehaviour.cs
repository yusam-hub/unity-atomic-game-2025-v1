using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyAttackBehaviour : IEntityInit, IEntityUpdate
    {
        private IReactiveVariable<IEntity> _targetAttackable;
        private Transform _transform;
        private IReactiveVariable<Vector3> _moveDirection;
        private readonly Cooldown _attackPeriod;

        public EnemyAttackBehaviour(
            Cooldown attackPeriod
        )
        {
            _attackPeriod = attackPeriod;
        }
        
        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            _targetAttackable = entity.GetTargetAttackable();
            _moveDirection = entity.GetMoveDirection();
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (_targetAttackable.Value == null) return;
            Vector3 targetPosition = _targetAttackable.Value.GetTransform().position;
            
            _moveDirection.Value = (targetPosition - _transform.position).normalized;
            entity.TransformRotateByDirection(_moveDirection.Value, deltaTime);
            
            _attackPeriod.Tick(deltaTime);
            
            if (_attackPeriod.IsExpired())
            {
                _attackPeriod.Reset();
                entity.GetWeaponFireAction().Invoke();
            }
        }
    }
}