using System;
using Atomic.Contexts;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class CharacterSystemInstaller : IContextInstaller<IPlayerContext>
    {
        //[SerializeField]
        private SceneEntity _character;

        [SerializeField, AssetsOnly]
        private GameObject _characterPrefab;
        
        public void Install(IPlayerContext context)
        {
            GameObject gameObject = SceneEntity.Instantiate(_characterPrefab);
            _character = gameObject.GetComponent<SceneEntity>();
            
            context.AddCharacter(_character);
            context.AddController<CharacterMoveController>();
            context.AddController<CharacterJumpController>();
        }
    }
}