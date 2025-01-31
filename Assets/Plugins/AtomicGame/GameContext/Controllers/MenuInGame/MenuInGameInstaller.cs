using System;
using Atomic.Contexts;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class MenuInGameInstaller : IContextInstaller<IGameContext>
    {
        private GameContextMenuInGamePresenter _gameContextMenuInGamePresenter;
        public void Install(IGameContext context)
        {
            _gameContextMenuInGamePresenter = GameObject.FindObjectOfType<GameContextMenuInGamePresenter>();
            _gameContextMenuInGamePresenter.gameObject.SetActive(false);
            
            _gameContextMenuInGamePresenter.exitButton.onClick.AddListener(ApplicationHelper.QuitBuildAndEditor);
            
            _gameContextMenuInGamePresenter.backToGameButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _gameContextMenuInGamePresenter.gameObject.SetActive(false);
                ApplicationHelper.Resume();
            });

            _gameContextMenuInGamePresenter.volumeSlider.value = context.GetAudioVolume().Value;
            _gameContextMenuInGamePresenter.volumeSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioVolume().Value = value;
            });
            
            _gameContextMenuInGamePresenter.musicSlider.value = context.GetAudioMusic().Value;
            _gameContextMenuInGamePresenter.musicSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioMusic().Value = value;   
            });
            
            _gameContextMenuInGamePresenter.effectSlider.value = context.GetAudioEffect().Value;
            _gameContextMenuInGamePresenter.effectSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioEffect().Value = value;
            });
            
            context.AddController(new MenuInGameController(_gameContextMenuInGamePresenter));
        }
    }
}