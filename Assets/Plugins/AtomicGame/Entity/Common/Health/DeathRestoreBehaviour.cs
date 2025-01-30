using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class DeathRestoreBehaviour : IEntityInit, IEntityDispose
    {
        private IReactiveValue<int> _health;
        private IEvent _deathEvent;
        private IEvent _restoreEvent;
        private int _lastHealth;
        
        public void Init(in IEntity entity)
        {
            _deathEvent = entity.GetDeathEvent();
            _restoreEvent = entity.GetRestoreEvent();
            _health = entity.GetHealth();
            _health.Subscribe(this.OnHealthChanged);
        }

        public void Dispose(in IEntity entity)
        {
            _health.Unsubscribe(this.OnHealthChanged);
        }
    
        private void OnHealthChanged(int health)
        {
            if (health <= 0)
            {
                _deathEvent.Invoke();
            } 
            else if (_lastHealth <= 0)
            {
                _restoreEvent.Invoke();
            }

            _lastHealth = health;
        }
    }
}
