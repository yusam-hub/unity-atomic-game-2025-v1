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
        private float _radius = 5;

        [SerializeField]
        private LayerMask _layerMask;

        [SerializeField]
        private QueryTriggerInteraction _triggerInteraction;

        [SerializeField]
        private float _cooldownPeriod = 0.1f;

        [SerializeField, ReadOnly]
        private ReactiveVariable<IEntity> _targetAttackable = new();
        
        public void Install(IEntity entity)
        {
            entity.AddTargetAttackable(_targetAttackable);
            
            entity.AddBehaviour(
                new DetectAttackableBehaviour(
                    entity.GetTransform(), 
                    _radius, 
                    _layerMask, 
                    _triggerInteraction,
                new Cooldown(_cooldownPeriod)
                    )
                );
            
            entity.GetTargetAttackable().Subscribe((target) =>
            {
                Debug.Log(target != null ? $"{target.Name}" : $"null");
            });
        }
    }
}