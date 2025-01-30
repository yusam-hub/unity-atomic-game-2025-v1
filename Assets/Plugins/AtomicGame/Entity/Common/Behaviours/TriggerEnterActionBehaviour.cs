using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class TriggerEnterActionBehaviour : IEntityInit, IEntityDispose
    {
        private IAction _triggerEnterAction;   
        private TriggerDispatcher _trigger;

        public TriggerEnterActionBehaviour()
        {

        }

        public void Init(in IEntity entity)
        {
            _triggerEnterAction = entity.GetTriggerEnterAction();
            _trigger = entity.GetTriggerDispatcher();
            _trigger.OnEnter += this.OnTriggerEnter;
        }

        public void Dispose(in IEntity entity)
        {
            _trigger.OnEnter -= this.OnTriggerEnter;
        }

        private void OnTriggerEnter(Collider collider)
        {
            _triggerEnterAction.Invoke();
        }

    }
}