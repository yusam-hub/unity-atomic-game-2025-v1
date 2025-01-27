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
        private Camera _camera;

        [SerializeField]
        private Vector3 _cameraFollowOffset = new Vector3(0, 5, -5);

        [SerializeField] 
        private bool _cameraThirdPersonEnabled;
        
        public void Install(IPlayerContext context)
        {
            context.AddCamera(_camera);
            
            if (_cameraThirdPersonEnabled)
            {
                context.AddCameraPlanarRotation(new ReactiveVariable<Quaternion>());
                context.AddController<CameraThirdPersonController>(); 
            }
            else
            {
                context.AddCameraFollowOffset(new Const<Vector3>(_cameraFollowOffset));
                context.AddController<CameraFollowController>();
            }

        }
    }
}