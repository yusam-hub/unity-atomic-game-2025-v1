using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class CharacterVisualInstaller: SceneEntityInstaller
    {
        [SerializeField]
        private AudioClip _jumpClip;

        public override void Install(IEntity entity)
        {
            entity.GetJumpEvent().Subscribe(() =>
            {
                AudioManager.PlayOneShot(_jumpClip);
            });
        }
    }
}