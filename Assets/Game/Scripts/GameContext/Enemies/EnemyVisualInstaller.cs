using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyVisualInstaller: SceneEntityInstaller
    {
        [SerializeField] 
        private GameObject _deathParticleSystemPrefab;
        
        [SerializeField] 
        private AudioClip _deathAudioClip;
        public override void Install(IEntity entity)
        {
            entity.GetDeathEvent().Subscribe(() =>
            {
                Destroy(
                    Instantiate(_deathParticleSystemPrefab, entity.GetTransform().position, entity.GetTransform().rotation), 
                    3
                    );
                
                AudioManager.PlayOneShot(_deathAudioClip);
            });
        }
    }
}