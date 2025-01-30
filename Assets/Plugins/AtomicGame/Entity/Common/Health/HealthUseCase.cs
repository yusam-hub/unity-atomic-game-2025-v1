using System;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using UnityEngine;

namespace AtomicGame
{
    public static class HealthUseCase
    {
        public static bool IsAlive(this IEntity entity)
        {
            if (!entity.HasDamageableTag())
            {
                return false;
            }
            return entity.GetHealth().Value > 0;
        }

        public static bool TakeDamage(this IEntity entity, in int damage)
        {
            if (!entity.HasDamageableTag())
            {
                return false;
            }

            IReactiveVariable<int> health = entity.GetHealth();
            
            int current = health.Value;
            
            if (current <= 0)
            {
                return false;
            }

            health.Value = Math.Max(0, current - damage);
            
            return true;
        }
    }
}