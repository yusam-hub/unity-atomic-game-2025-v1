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
        private SceneEntity _character;
        
        [SerializeField]
        private Transform _spawnPoint;

        [SerializeField, AssetsOnly]
        private GameObject _characterPrefab;
        
        private PlayerContextHealthPresenter _healthPresenter; 
        
        public void Install(IPlayerContext context)
        {
            GameObject gameObject = SceneEntity.Instantiate(_characterPrefab, _spawnPoint.position, _spawnPoint.rotation);
            
            _character = gameObject.GetComponent<SceneEntity>();
            
            context.AddCharacter(_character);
            context.AddController<CharacterMoveController>();
            context.AddController<CharacterJumpController>();
            context.AddController<CharacterInteractController>();
            
            _healthPresenter = SceneEntity.FindObjectOfType<PlayerContextHealthPresenter>();
            if (_healthPresenter)
            {
                _healthPresenter.health.text = _character.GetHealth().Value.ToString();
                _character.GetHealth().Subscribe((value) => { _healthPresenter.health.text = value.ToString(); });
            }
        }
    }
}