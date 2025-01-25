using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class PlayerContextInstaller : SceneContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private InputMap _inputMap;
        
        [SerializeField]
        private Transform _spawnPoint;
        
        [SerializeField]
        private CharacterSystemInstaller _characterInstaller;
        
        protected override void Install(IPlayerContext context)
        {
            context.AddInputMap(_inputMap);
            _characterInstaller.Install(context);
        }
    }
}