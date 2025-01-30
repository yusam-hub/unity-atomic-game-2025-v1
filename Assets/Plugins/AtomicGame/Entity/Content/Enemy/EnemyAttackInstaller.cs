using System;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class EnemyAttackInstaller : IEntityInstaller
    {
        [SerializeField]
        private float _detectRadius = 10;

        [SerializeField]
        private LayerMask _detectLayerMask;

        [SerializeField]
        private QueryTriggerInteraction _detectTriggerInteraction;

        [SerializeField]
        private float _detectCooldownPeriod = 0.1f;
        
        [SerializeField]
        private float _attackCooldownPeriod = 1f;

        [SerializeField, ReadOnly]
        private ReactiveVariable<IEntity> _targetAttackable = new();
        
        public void Install(IEntity entity)
        {
            entity.AddTargetAttackable(_targetAttackable);
            
            entity.AddBehaviour(
                new EnemyDetectAttackableBehaviour(
                    entity.GetTransform(), 
                    _detectRadius, 
                    _detectLayerMask, 
                    _detectTriggerInteraction,
                new Cooldown(_detectCooldownPeriod)
                    )
                );
            
            entity.AddBehaviour(
                new EnemyAttackBehaviour(
                    new Cooldown(_attackCooldownPeriod)
                    )
            );

        }
    }
}