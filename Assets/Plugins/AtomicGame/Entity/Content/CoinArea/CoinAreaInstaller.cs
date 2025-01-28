using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CoinAreaInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private TriggerDispatcher _trigger;

        [SerializeField]
        private bool _isRotate;
        
        [SerializeField]
        private float _rotateSpeed = 200f;
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(transform);
            entity.AddTriggerDispatcher(_trigger);
            entity.AddBehaviour(new CoinAreaBehaviour(_isRotate, _rotateSpeed));
        }
    }
}