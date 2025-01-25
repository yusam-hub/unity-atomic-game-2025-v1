using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    [CreateAssetMenu(
        fileName = "MoveSpeedAspect",
        menuName = "Ag/Aspects/New MoveSpeedAspect"
    )]
    public sealed class MoveSpeedAspect : ScriptableEntityAspect
    {
        [SerializeField]
        private Const<float> _multiplier;

        public override void Apply(IEntity entity)
        {
            if (entity.TryGetMoveSpeed(out IReactiveVariable<float> speed))
                speed.Value *= _multiplier.Value;
        }

        public override void Discard(IEntity entity)
        {
            if (entity.TryGetMoveSpeed(out IReactiveVariable<float> speed))
                speed.Value /= _multiplier.Value;
        }
    }
}