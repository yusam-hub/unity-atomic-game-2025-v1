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
        private MenuInGameInstaller _menuInGameInstaller;

        [SerializeField]
        private GameOverInstaller _gameOverInstaller;

        [SerializeField]
        private GameWinInstaller _gameWinInstaller;
        
        [SerializeField]
        private GameContextConfig _gameContextConfig;
        
        [SerializeField] 
        private Transform _bulletPool;
        
        [SerializeField]
        private ReactiveVariable<int> _coinScore = new();
        
        [SerializeField]
        private ReactiveVariable<int> _keyScore = new();
        
        [SerializeField]
        private ReactiveVariable<int> _pumpkinScore = new();

        [SerializeField] 
        private ReactiveVariable<float> _audioVolume = new(1);
        
        [SerializeField] 
        private ReactiveVariable<float> _audioMusic = new(1);
        
        [SerializeField] 
        private ReactiveVariable<float> _audioEffect = new(1);
        
        [SerializeField, ReadOnly] 
        private ReactiveVariable<GameContextState> _gameState = new(GameContextState.statePlay);
        protected override void Install(IGameContext context)
        {
            context.AddBulletSceneEntityPool(new GenericSceneEntityPool(_bulletPool));
            context.AddCoinScore(_coinScore);
            context.AddKeyScore(_keyScore);
            context.AddPumpkinScore(_pumpkinScore);
            context.AddGameContextConfig(_gameContextConfig);
            context.AddAudioVolume(_audioVolume);
            context.AddAudioMusic(_audioMusic);
            context.AddAudioEffect(_audioEffect);
            context.AddGameOverBeginEvent(new BaseEvent());
            context.AddGameOverEndEvent(new BaseEvent());
            context.AddGameState(_gameState);
            context.AddKeysOnLevel(new ReactiveInt(0));
            
            _menuInGameInstaller.Install(context);
            _gameOverInstaller.Install(context);
            _gameWinInstaller.Install(context);
            
        }
    }
}