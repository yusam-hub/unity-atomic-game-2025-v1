using System;
using UnityEngine;
using UnityEngine.UI;

namespace AtomicGame
{
    public sealed class GameContextMoveSpacePresenter : MonoBehaviour
    {
        public Image imageUp;
        public Image imageUpSelected;

        public Image imageDown;
        public Image imageDownSelected;
        
        public Image imageLeft;
        public Image imageLeftSelected;
        
        public Image imageRight;
        public Image imageRightSelected;
        
        public Image imageJump;
        public Image imageJumpSelected;

        private PlayerContext _playerContext;

        private void Start()
        {
            _playerContext = PlayerContext.Instance;
        }

        private void Update()
        {
            var dir = InputUseCase.GetMoveDirection(_playerContext);
            imageUpSelected.gameObject.SetActive(dir.z > 0);
            imageDownSelected.gameObject.SetActive(dir.z < 0);
            imageRightSelected.gameObject.SetActive(dir.x > 0);
            imageLeftSelected.gameObject.SetActive(dir.x < 0);
            
            
            imageJumpSelected.gameObject.SetActive(InputUseCase.IsJumpPress(_playerContext));
        }
    }
}