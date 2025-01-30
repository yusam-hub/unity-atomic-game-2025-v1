using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private GameContextConfig _gameContextConfig;
        
        [SerializeField] 
        private Transform _bulletPool;
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<int> _coinScore = new();
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<int> _keyScore = new();
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<int> _pumpkinScore = new();
        protected override void Install(IGameContext context)
        {
            context.AddBulletSceneEntityPool(new GenericSceneEntityPool(_bulletPool));
            context.AddCoinScore(_coinScore);
            context.AddKeyScore(_keyScore);
            context.AddPumpkinScore(_pumpkinScore);
            context.AddGameContextConfig(_gameContextConfig);
        }
    }
}