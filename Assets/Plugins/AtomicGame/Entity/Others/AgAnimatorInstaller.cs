using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public class AgAnimatorInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private Animator _animator;

        [SerializeField, ReadOnly] 
        private ReactiveVariable<int> _currentState = new(-1);
        
        [SerializeField, ReadOnly]
        private BaseEvent<int> _changeCrossFadeEvent = new();
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddAnimatorCurrentState(_currentState);
            entity.AddChangeCrossFadeEvent(_changeCrossFadeEvent);

            _changeCrossFadeEvent.Subscribe((hashKey) =>
            {
                if (_currentState.Value != hashKey)
                {
                    _currentState.Value = hashKey;
                    _animator.CrossFade(
                        _currentState.Value,
                        0,
                        0,
                        0,
                        0
                    );
                }
            });

            entity.WhenLateUpdate(entity.AgHumanAnimatorChangeCrossFadeEventLateUpdate);
        }

    }
}