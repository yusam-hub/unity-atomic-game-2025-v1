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
        private CharacterSystemInstaller _characterSystemInstaller;
        
        [SerializeField]
        private CameraSystemInstaller _cameraSystemInstaller;
        protected override void Install(IPlayerContext context)
        {
            context.AddInputMap(_inputMap);
            
            _characterSystemInstaller.Install(context);
            
            _cameraSystemInstaller.Install(context);
        }
    }
}