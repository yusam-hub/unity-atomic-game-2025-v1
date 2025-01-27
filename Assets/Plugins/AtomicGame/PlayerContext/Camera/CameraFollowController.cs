using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CameraFollowController : IContextInit<IPlayerContext>, IContextLateUpdate
    {
        private Transform _character;
        private Transform _camera;
        private IValue<Vector3> _offset;
        
        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter().GetTransform();
            _camera = context.GetCamera().transform;
            _offset = context.GetCameraFollowOffset();
        }

        public void OnLateUpdate(IContext context, float deltaTime)
        {
            _camera.position = _character.position + _offset.Value;
        }

    }
}