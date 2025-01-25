using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class EffectAreaBehaviour : IEntityInit, IEntityDispose
    {
        private readonly IEntityAspect _effect;
        private TriggerDispatcher _trigger;

        public EffectAreaBehaviour(IEntityAspect effect)
        {
            _effect = effect;
        }

        public void Init(in IEntity entity)
        {
            _trigger = entity.GetTriggerDispatcher();
            _trigger.OnEnter += this.OnTriggerEnter;
            _trigger.OnExit += this.OnTriggerExit;
        }

        public void Dispose(in IEntity entity)
        {
            _trigger.OnEnter -= this.OnTriggerEnter;
            _trigger.OnExit -= this.OnTriggerExit;
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.TryGetComponent(out IEntity entity))
                _effect.Apply(entity);
        }

        private void OnTriggerExit(Collider collider)
        {
            if (collider.TryGetComponent(out IEntity entity))
                _effect.Discard(entity);
        }
    }
}