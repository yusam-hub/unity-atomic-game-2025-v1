using System;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using UnityEngine;

namespace AtomicGame
{
    public sealed class BulletCollisionBehaviour : IEntityInit, IEntityDispose
    {

        private TriggerDispatcher _triggerDispatcher;
        private IValue<int> _damage;
        private IAction _destroyAction;
        private IAction _damageAction;
        public void Init(in IEntity entity)
        {
            _destroyAction = entity.GetDestroyAction();
            _damageAction = entity.GetDamageAction();
            _damage = entity.GetDamage();
            _triggerDispatcher = entity.GetTriggerDispatcher();

            _triggerDispatcher.OnEnter += this.OnTriggerEnter;
        }

        public void Dispose(in IEntity entity)
        {
            _triggerDispatcher.OnEnter -= this.OnTriggerEnter;
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.TryGetComponent(out IEntity target))
            {
                if (target.TakeDamage(_damage.Value))
                {
                    _damageAction.Invoke();
                }
            }
            
            _destroyAction.Invoke();
        }
    }
}