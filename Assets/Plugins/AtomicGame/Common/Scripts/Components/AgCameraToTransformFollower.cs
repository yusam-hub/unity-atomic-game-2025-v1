using Atomic.Entities;
using AtomicGame.Common;
using UnityEngine;

namespace AtomicGame.Common
{
    public sealed class AgCameraToTransformFollower : MonoBehaviour
    {
        [SerializeField]
        private Camera _camera;
        
        [SerializeField] 
        private SceneEntity _sceneEntity;
        
        [SerializeField]
        private Vector3 offset = new(0,5,-5);
        
        private void LateUpdate()
        {
            if (!_sceneEntity.HasTransform())
            {
                Debug.LogError($"Transform of entity api not found!");
                return;
            }
            Vector3 cameraPosition = _sceneEntity.GetTransform().position + this.offset;
            _camera.transform.position = cameraPosition;
        }
    }
}

