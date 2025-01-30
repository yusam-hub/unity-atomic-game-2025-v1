using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Android;

namespace AtomicGame
{
    public sealed class CharacterControllerDamageTriggerBehaviour : IEntityInit, IEntityDispose
    {
        private TriggerDispatcher _triggerDispatcher;

        public CharacterControllerDamageTriggerBehaviour(
            TriggerDispatcher triggerDispatcher

            )
        {
            _triggerDispatcher = triggerDispatcher;
        }

        public void Init(in IEntity entity)
        {
            _triggerDispatcher.OnEnter += TriggerDispatcherOnOnEnter;
        }

        private void TriggerDispatcherOnOnEnter(Collider other)
        {
            if (!other.TryGetEntity(out IEntity target))
            {
                return;
            }

            if (target.HasEnemyTag())
            {
                target.TakeDamage(1000);       
            }
        }

        public void Dispose(in IEntity entity)
        {
            _triggerDispatcher.OnEnter -= TriggerDispatcherOnOnEnter;
        }
        
    }
}