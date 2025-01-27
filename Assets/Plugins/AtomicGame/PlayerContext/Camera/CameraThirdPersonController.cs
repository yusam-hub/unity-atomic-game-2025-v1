using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CameraThirdPersonController : IContextInit<IPlayerContext>, IContextUpdate, IContextLateUpdate
    {
        private IReactiveVariable<Quaternion> _cameraPlanarRotation;
        private IEntity _character;
        private Transform _camera;

        private float _rotationSpeed = 2;

        private float _rotationY;
        private float _rotationX;
        
        private float _minVerticalAngle = -5;
        private float _maxVerticalAngle = 45;
        private Vector2 _framingOffset = new Vector2(0,1);
        
        private bool _invertZoom = true;
        private bool _invertX = false;
        private bool _invertY = true;
        
        private float _invertZoomVal;
        private float _invertXVal;
        private float _invertYVal;
        
        private float _minZoomDistance = 3;
        private float _maxZoomDistance = 10;
        private float _currentZoomDistance = 5;
        private float _zoomSpeed = 2;
        private Quaternion _targetRotation;
        private Vector3 _focusPosition;
        
        public void Init(IPlayerContext context)
        {
            _cameraPlanarRotation = context.GetCameraPlanarRotation();
            _character = context.GetCharacter();
            _camera = context.GetCamera().transform;
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _invertZoomVal = _invertZoom ? -1 : 1;
            
            _currentZoomDistance += Input.GetAxisRaw("Mouse ScrollWheel") * _zoomSpeed * _invertZoomVal;
            _currentZoomDistance = Mathf.Clamp(_currentZoomDistance, _minZoomDistance, _maxZoomDistance);
            
            _invertXVal = _invertX ? -1 : 1;
            _invertYVal = _invertY ? -1 : 1;
            
            _rotationX += Input.GetAxis("Mouse Y") * _invertYVal * _rotationSpeed;
            _rotationX = Mathf.Clamp(_rotationX, _minVerticalAngle, _maxVerticalAngle);
            
            _rotationY += Input.GetAxis("Mouse X") * _invertXVal * _rotationSpeed;

            _focusPosition = _character.GetTransform().position + new Vector3(_framingOffset.x, _framingOffset.y);

            _targetRotation = Quaternion.Euler(_rotationX, _rotationY, 0);
            _cameraPlanarRotation.Value = Quaternion.Euler(0, _rotationY, 0);
            
            _character.GetPlanarRotation().Value = _cameraPlanarRotation.Value;//send to character
        }

        public void OnLateUpdate(IContext context, float deltaTime)
        {
            _camera.position = _focusPosition - _targetRotation * new Vector3(0, 0, _currentZoomDistance);
            _camera.rotation = _targetRotation;
        }

    }
}