using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public class TransformMoveThrowPointsInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private Transform _transform;
        
        [SerializeField] 
        private ReactiveVariable<float> _moveSpeed = new(1f);
        
        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(200f);
        
        [SerializeField] 
        private ReactiveVariable<float> _rotateAngle = new (1f);
       
        [SerializeField] 
        private Vector3 _rotateDirection = new (0f,1f,0f);
        
        [SerializeField] 
        private Transform[] _points;
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(_transform);
            entity.AddTransforms(_points);
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddBehaviour(new TransformMoveThrowPointsBehaviour(_rotateAngle, _rotateDirection));
        }
    }
}