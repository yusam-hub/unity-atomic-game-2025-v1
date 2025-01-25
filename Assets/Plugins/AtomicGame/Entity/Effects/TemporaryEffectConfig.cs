using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public abstract class TemporaryEffectConfig : EffectConfig
    {
        [field: SerializeField]
        public Const<float> Duration { get; private set; }
    }
    
    
    
}