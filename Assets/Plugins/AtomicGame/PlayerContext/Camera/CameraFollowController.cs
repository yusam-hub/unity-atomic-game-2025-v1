using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CameraFollowController : IContextInit<IPlayerContext>, IContextLateUpdate
    {
        private IEntity _character;
        private Transform _camera;
        private IValue<Vector3> _offset;
        
        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
            _camera = context.GetCamera().transform;
            _offset = context.GetCameraOffset();
        }

        public void OnLateUpdate(IContext context, float deltaTime)
        {
            _camera.position = _character.GetTransform().position + _offset.Value;
        }
    }
}