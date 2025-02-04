using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public class FinishLevelInstaller : SceneEntityInstaller, IEntityDispose
    {
        [SerializeField]
        private int _requireKeys = 3;

        [SerializeField]
        private TriggerDispatcher _triggerDispatcher;
        
        public override void Install(IEntity entity)
        {
            _triggerDispatcher.OnEnter += TriggerDispatcherOnOnEnter;
        }

        private void TriggerDispatcherOnOnEnter(Collider collider)
        {
            if (!collider.TryGetEntity(out IEntity target))
            {
                //Debug.Log($"Not found entity target");
                return;
            }

            if (!target.HasPlayerTag())
            {
                //Debug.Log($"Not found player tag");
                return;
            }

            if (GameContext.Instance.GetKeyScore().Value != _requireKeys)
            {
                //Debug.Log($"No keys matches {GameContext.Instance.GetKeyScore().Value} != {_requireKeys}");
                return;
            }
            
            GameContext.Instance.GetGameWinAction().Invoke();
        }

        public void Dispose(in IEntity entity)
        {
            _triggerDispatcher.OnEnter -= TriggerDispatcherOnOnEnter;
        }

        [Button]
        public void GameWinDebug()
        {
            GameContext.Instance.GetGameWinAction().Invoke();
        }
    }
}