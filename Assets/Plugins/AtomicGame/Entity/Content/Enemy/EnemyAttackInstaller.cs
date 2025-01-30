using System;
using Atomic.Elements;
using Atomic.Entities;
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
        
        public void Install(IEntity entity)
        {
            entity.AddTargetAttackable(new ReactiveVariable<IEntity>());
            
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