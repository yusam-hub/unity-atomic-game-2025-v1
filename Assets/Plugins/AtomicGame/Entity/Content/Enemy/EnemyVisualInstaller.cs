using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyVisualInstaller: SceneEntityInstaller
    {
        [SerializeField] 
        private GameContextConfig _gameContextConfig;

        public override void Install(IEntity entity)
        {
            entity.GetDeathEvent().Subscribe(() =>
            {
                Destroy(
                    Instantiate(_gameContextConfig.vfxPrefabConfig.pumpkinDeathPrefab, entity.GetTransform().position, entity.GetTransform().rotation), 
                    3
                    );
                
                GameContextAudioManager.PlayOneShot(_gameContextConfig.audioClipConfig.pumpkinDeath);
            });
            
            entity.GetWeaponFireEvent().Subscribe(() =>
            {
                GameContextAudioManager.PlayOneShot(_gameContextConfig.audioClipConfig.pumpkinAttack);
            });
        }
    }
}