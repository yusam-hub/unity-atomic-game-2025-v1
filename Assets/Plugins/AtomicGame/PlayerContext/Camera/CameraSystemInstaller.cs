using System;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class CameraSystemInstaller : IContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private Vector3 _cameraOffset = new Vector3(0, 5, -5);

        [SerializeField]
        private Camera _camera;
        
        public void Install(IPlayerContext context)
        {
            context.AddCameraOffset(new Const<Vector3>(_cameraOffset));
            context.AddCamera(_camera);
            context.AddController<CameraFollowController>();
        }
    }
}