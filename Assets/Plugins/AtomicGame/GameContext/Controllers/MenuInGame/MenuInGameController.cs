using Atomic.Contexts;
using UnityEngine;

namespace AtomicGame
{
    public class MenuInGameController : IContextInit<IGameContext>, IContextUpdate<IGameContext>
    {
        private PlayerContext _playerContext;
        private GameContextMenuInGamePresenter _gameContextMenuInGamePresenter;

        public MenuInGameController(GameContextMenuInGamePresenter gameContextMenuInGamePresenter)
        {
            _gameContextMenuInGamePresenter = gameContextMenuInGamePresenter;
        }

        public void Init(IGameContext context)
        {
            _playerContext = PlayerContext.Instance;
             ApplicationHelper.HideCursor();    
             ApplicationHelper.Resume();
        }

        public void OnUpdate(IGameContext context, float deltaTime)
        {
            if (InputUseCase.IsPause(_playerContext) && !_gameContextMenuInGamePresenter.gameObject.activeSelf)
            {
                _gameContextMenuInGamePresenter.gameObject.SetActive(true);  
                ApplicationHelper.ShowCursor();       
                ApplicationHelper.Pause();
                _gameContextMenuInGamePresenter.volumeSlider.value = context.GetAudioVolume().Value;
                _gameContextMenuInGamePresenter.musicSlider.value = context.GetAudioMusic().Value;
                _gameContextMenuInGamePresenter.effectSlider.value = context.GetAudioEffect().Value;
            }
        }
    }
}