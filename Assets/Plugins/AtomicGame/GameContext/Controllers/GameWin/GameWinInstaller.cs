using System;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class GameWinInstaller : IContextInstaller<IGameContext>
    {
        private GameContextGameWinPresenter _gameWinPresenter;
        private SceneLoaderComponent _sceneLoaderComponent;
        private SceneRestartComponent _sceneRestartComponent;
        private SceneNextLevelComponent _sceneNextLevelComponent;
        public void Install(IGameContext context)
        {
            _sceneLoaderComponent = GameObject.FindObjectOfType<SceneLoaderComponent>();
            _sceneRestartComponent = GameObject.FindObjectOfType<SceneRestartComponent>();
            _sceneNextLevelComponent = GameObject.FindObjectOfType<SceneNextLevelComponent>();
                        
            _gameWinPresenter = GameObject.FindObjectOfType<GameContextGameWinPresenter>(true);
            _gameWinPresenter.gameObject.SetActive(false);
            
            _gameWinPresenter.exitButton.onClick.AddListener(ApplicationHelper.QuitBuildAndEditor);

            _gameWinPresenter.nextLevelButton.gameObject.SetActive(
                SceneHelper.IsSceneExist(_sceneNextLevelComponent.GetNextSceneName())
                );

            _gameWinPresenter.nextLevelButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneNextLevelComponent.SceneLoaderStartHandler();
            });
            
            _gameWinPresenter.restartButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneRestartComponent.SceneLoaderStartHandler();
            });
            
            _gameWinPresenter.backToMainMenuButton.onClick.AddListener(() => { 
                ApplicationHelper.HideCursor();
                _sceneLoaderComponent.SceneLoaderStartHandler();
            });

            context.AddGameWinAction(new BaseAction(() =>
            {
                GameContextAudioManager.Instance.musicSource.Stop();
                GameContextAudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.gameWin);
                context.GetGameState().Value = GameContextState.stateWin;
                _gameWinPresenter.gameObject.SetActive(true);
                ApplicationHelper.ShowCursor();
                ApplicationHelper.Pause();
            }));
        }
    }
}