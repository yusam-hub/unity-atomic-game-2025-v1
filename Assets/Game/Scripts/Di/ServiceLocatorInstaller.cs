using System;
using UnityEngine;

namespace Game
{
    public sealed class ServiceLocatorInstaller : MonoBehaviour
    {
        [SerializeField]
        private Character character;

        [SerializeField]
        private DirectionVector3 directionInput;

        [SerializeField]
        private new Camera camera;
        private void Awake()
        {
            ServiceLocator.ListAddService(character);
            ServiceLocator.ListAddService(directionInput);
            ServiceLocator.ListAddService(camera);
            
            ServiceLocator.TypeAddService<ICharacter>(character);
            ServiceLocator.TypeAddService<IDirectionVector3>(directionInput);
            ServiceLocator.TypeAddService<Camera>(camera);
            
            ServiceLocator.IdAddService(ServiceLocator.SL_CHARACTER, character);
            ServiceLocator.IdAddService(ServiceLocator.SL_DIRECTION_VECTOR3, directionInput);
            ServiceLocator.IdAddService(ServiceLocator.SL_CAMERA, camera);
        }
    }
}