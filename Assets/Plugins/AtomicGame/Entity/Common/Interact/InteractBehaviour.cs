using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    /*public sealed class InteractBehaviour : IEntityInit, IEntityDispose
    {
        private TriggerDispatcher _trigger;
        private IEntity _entity;
        
        public void Init(in IEntity entity)
        {
            _entity = entity;
            _trigger = entity.GetTriggerDispatcher();
            _trigger.OnEnter += this.OnTriggerEnter;
        }

        public void Dispose(in IEntity entity)
        {
            _trigger.OnEnter -= this.OnTriggerEnter;
        }

        private void OnTriggerEnter(Collider collider)
        {
            InteractUseCase.Interact(_entity, collider);
        }
    }*/
}