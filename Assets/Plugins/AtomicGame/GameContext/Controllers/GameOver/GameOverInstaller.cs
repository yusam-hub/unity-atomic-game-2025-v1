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
        private SceneRestartComponent _sceneRestartComponent;
        public void Install(IGameContext context)
        {
            _sceneLoaderComponent = GameObject.FindObjectOfType<SceneLoaderComponent>();
            _sceneRestartComponent = GameObject.FindObjectOfType<SceneRestartComponent>();
            
            Debug.Log($"_sceneLoaderComponent = {_sceneLoaderComponent.GetSceneName()}");
            Debug.Log($"_sceneRestartComponent = {_sceneRestartComponent.GetSceneName()}");
            
            _gameOverPresenter = GameObject.FindObjectOfType<GameContextGameOverPresenter>(true);
            _gameOverPresenter.gameObject.SetActive(false);
            
            _gameOverPresenter.exitButton.onClick.AddListener(ApplicationHelper.QuitBuildAndEditor);
            
            _gameOverPresenter.restartButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneRestartComponent.SceneLoaderStartHandler();
            });
            
            _gameOverPresenter.backToMainMenuButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneLoaderComponent.SceneLoaderStartHandler();
            });

            context.GetGameOverEndEvent().Subscribe(() =>
            {
                GameContextAudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.gameOver);
                context.GetGameState().Value = GameContextState.stateGameOver;
                _gameOverPresenter.gameObject.SetActive(true);
                ApplicationHelper.ShowCursor();
                ApplicationHelper.Pause();
            });

            context.AddController(new GameOverController(new Cooldown(3, 0)));
        }
    }
}