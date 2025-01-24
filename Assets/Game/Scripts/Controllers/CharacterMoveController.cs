using UnityEngine;

namespace Game
{
    public sealed class CharacterMoveController : MonoBehaviour
    {
        private IDirectionVector3 _directionVector3;
        private ICharacter _character;      
        
        [Inject]
        public void Construct(IDirectionVector3 directionVector3, ICharacter character)
        {
            _directionVector3 = directionVector3;
            _character = character;
        }

        private void Update()
        {
            _character.Move(this._directionVector3.GetDirection(), Time.deltaTime);
        }
    }
}