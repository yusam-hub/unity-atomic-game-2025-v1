using System;
using UnityEngine;

namespace Game
{
    public sealed class CharacterCommandController : MonoBehaviour
    {
        [SerializeField] 
        private Character character;
        
        private IGroundRaycaster _groundRaycaster;
        private ICommandInput _commandInput;
        private void Awake()
        {
            _groundRaycaster = new GroundRaycaster();
            _commandInput = new CommandInput();
        }

        private void Update()
        {
            if (!_commandInput.IsMoveRequired)
            {
                return;
            }

            if (!_groundRaycaster.Raycast(_commandInput.MousePosition, out Vector3 groundPosition))
            {
                return; 
            }
  
            character.MoveTo(groundPosition);
        }
    }
}