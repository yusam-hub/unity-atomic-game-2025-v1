using System;
using Atomic.Contexts;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class MenuInGameInstaller : IContextInstaller<IGameContext>
    {
        private GameContextMenuInGamePresenter _gameContextMenuInGamePresenter;
        private SceneLoaderComponent _sceneLoaderComponent;
        private SceneRestartComponent _sceneRestartComponent;
        public void Install(IGameContext context)
        {
            _sceneLoaderComponent = GameObject.FindObjectOfType<SceneLoaderComponent>();
            _sceneRestartComponent = GameObject.FindObjectOfType<SceneRestartComponent>();
            
            _gameContextMenuInGamePresenter = GameObject.FindObjectOfType<GameContextMenuInGamePresenter>(true);
            _gameContextMenuInGamePresenter.gameObject.SetActive(false);
            
            _gameContextMenuInGamePresenter.exitButton.onClick.AddListener(ApplicationHelper.QuitBuildAndEditor);
            
            _gameContextMenuInGamePresenter.backToGameButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _gameContextMenuInGamePresenter.gameObject.SetActive(false);
                ApplicationHelper.Resume();
                context.GetGameState().Value = GameContextState.statePlay;
            });
            
            _gameContextMenuInGamePresenter.restartButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneRestartComponent.SceneLoaderStartHandler();
            });
            
            _gameContextMenuInGamePresenter.backToMainMenuButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneLoaderComponent.SceneLoaderStartHandler();
            });

            _gameContextMenuInGamePresenter.volumeSlider.value = context.GetAudioVolume().Value;
            _gameContextMenuInGamePresenter.musicSlider.value = context.GetAudioMusic().Value;
            _gameContextMenuInGamePresenter.effectSlider.value = context.GetAudioEffect().Value;
            
            _gameContextMenuInGamePresenter.volumeSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioVolume().Value = value;
            });

            _gameContextMenuInGamePresenter.musicSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioMusic().Value = value;   
            });
  
            _gameContextMenuInGamePresenter.effectSlider.onValueChanged.AddListener((value) =>
            {
                context.GetAudioEffect().Value = value;
            });
            
            context.AddController(new MenuInGameController(_gameContextMenuInGamePresenter));
        }
    }
}