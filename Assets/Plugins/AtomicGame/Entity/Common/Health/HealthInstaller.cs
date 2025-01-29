using System;
using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public class HealthInstaller : IEntityInstaller
    {
        [SerializeField] 
        private ReactiveVariable<int> _health = new(100);

        public void Install(IEntity entity)
        {
            entity.AddDamageableTag();
            entity.AddHealth(_health);
            entity.AddDeathEvent(new BaseEvent());

            entity.AddBehaviour(
                new DeathBehaviour()
            );
        }
    }
}