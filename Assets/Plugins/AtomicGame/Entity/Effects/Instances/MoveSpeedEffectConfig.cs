using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    [CreateAssetMenu(
        fileName = "MoveSpeedEffect",
        menuName = "Ag/Effects/New MoveSpeedEffect"
    )]
    
    
    public sealed class MoveSpeedEffectConfig : TemporaryEffectConfig
    {
        [field: SerializeField]
        public Const<float> Multiplier { get; private set; }

        public override bool CanApply(in IEntity target) => 
            target.HasMoveSpeed();

        protected override EffectInstance Create(in IEntity target) =>
            new MoveSpeedEffectInstance(this, target);
    }
}