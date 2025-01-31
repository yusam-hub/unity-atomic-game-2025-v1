using System;
using Atomic.Contexts;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class GameOverInstaller : IContextInstaller<IGameContext>
    {
        private GameContextGameOverPresenter _gameOverPresenter;
        private SceneLoaderComponent _sceneLoaderComponent;
        public void Install(IGameContext context)
        {
            _sceneLoaderComponent = GameObject.FindObjectOfType<SceneLoaderComponent>();
            _gameOverPresenter = GameObject.FindObjectOfType<GameContextGameOverPresenter>();
            _gameOverPresenter.gameObject.SetActive(false);
            
            _gameOverPresenter.exitButton.onClick.AddListener(ApplicationHelper.QuitBuildAndEditor);
            
            _gameOverPresenter.backToMainMenuButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneLoaderComponent.SceneLoaderStartHandler();
            });

            context.GetGameOverEndEvent().Subscribe(() =>
            {
                _gameOverPresenter.gameObject.SetActive(true);
                ApplicationHelper.ShowCursor();
                ApplicationHelper.Pause();
            });

            context.AddController(new GameOverController(new Cooldown(3, 0)));
        }
    }
}