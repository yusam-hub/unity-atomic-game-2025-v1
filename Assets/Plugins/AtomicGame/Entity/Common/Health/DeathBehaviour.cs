using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class DeathBehaviour : IEntityInit, IEntityDispose
    {
        private IReactiveValue<int> _health;
        private IEvent _deathEvent;
        
        public void Init(in IEntity entity)
        {
            _deathEvent = entity.GetDeathEvent();
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
                Debug.Log("$Death Invoke");
                _deathEvent.Invoke();
            }
        }
    }
}
