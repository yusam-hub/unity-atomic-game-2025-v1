using System;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public abstract class EffectInstance : IEntityBehaviour, IDisposable
    {
        public string Name => _config.Name;
        public string Description => _config.Description;
        public Sprite Icon => _config.Icon;

        private readonly EffectConfig _config;
        protected readonly IEntity _target;

        protected EffectInstance(in EffectConfig config, in IEntity target)
        {
            _config = config;
            _target = target;
            _target.AddBehaviour(this);
        }
        
        public void Dispose()
        {
            _target.DelBehaviour(this);
            this.OnDispose();
        }

        protected abstract void OnDispose();
    }
}