using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class CharacterVisualInstaller: SceneEntityInstaller
    {
        private GameContext _gameContext;
        public override void Install(IEntity entity)
        {
            _gameContext = GameContext.Instance;
            
            entity.GetJumpEvent().Subscribe(() =>
            {
                GameContextAudioManager.PlayOneShot(_gameContext.GetGameContextConfig().audioClipConfig.playerJump);
            });
            
            entity.GetDeathEvent().Subscribe(() =>
            {
                GameContextAudioManager.PlayOneShot(_gameContext.GetGameContextConfig().audioClipConfig.playerDeath);
            });
        }
    }
}