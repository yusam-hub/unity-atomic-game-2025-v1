using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class EffectAreaInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private TriggerDispatcher _trigger;

        [SerializeField]
        private ScriptableEntityAspect _effect;

        public override void Install(IEntity entity)
        {
            entity.AddTriggerDispatcher(_trigger);
            entity.AddBehaviour(new EffectAreaBehaviour(_effect));
        }
    }
}