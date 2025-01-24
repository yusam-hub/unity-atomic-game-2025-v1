using UnityEngine;

namespace Game
{
    public interface ICharacter
    {
        public void MoveTo(Vector3 destination);
        void Move(Vector3 direction, float deltaTime);
        Vector3 GetPosition();
    }
}