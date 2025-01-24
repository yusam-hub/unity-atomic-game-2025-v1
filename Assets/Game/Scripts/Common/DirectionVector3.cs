using UnityEngine;

namespace Game
{
    public abstract class DirectionVector3 : MonoBehaviour, IDirectionVector3
    {
        public abstract Vector3 GetDirection();
    }
}