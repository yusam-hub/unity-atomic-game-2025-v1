using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class ScoreableInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private TriggerDispatcher _trigger;

        [SerializeField]
        public ScoreableType _scoreableType;
        
        [SerializeField]
        private bool _isRotate;
        
        [SerializeField]
        private float _rotateSpeed = 200f;
        
        public override void Install(IEntity entity)
        {
            entity.AddScoreableTag();
            entity.AddTransform(transform);
            entity.AddTriggerDispatcher(_trigger);
            entity.AddTriggerEnterAction(new BaseAction(() =>
            {
                if (_scoreableType == ScoreableType.stCoin)
                {
                    IReactiveVariable<int> score = GameContext.Instance.GetCoinScore();
                    score.Value += 1;
                } else if (_scoreableType == ScoreableType.stKey)
                {
                    IReactiveVariable<int> score = GameContext.Instance.GetKeyScore();
                    score.Value += 1;
                } 
                
                transform.gameObject.SetActive(false);
            }));
            entity.AddBehaviour(new TriggerEnterActionBehaviour());
            entity.AddBehaviour(new TransformUpRotateBehaviour(_isRotate, _rotateSpeed));
        }

        private void OnEnable()
        {
            if (_scoreableType == ScoreableType.stKey)
            {
                GameContext.Instance.GetKeysOnLevel().Value++;
            }
        }
    }
}