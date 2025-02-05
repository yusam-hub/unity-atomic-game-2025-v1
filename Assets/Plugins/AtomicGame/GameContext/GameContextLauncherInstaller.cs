using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextLauncherInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField] 
        private SceneLoaderComponent _sceneLoaderComponent;
        
        [SerializeField] 
        private GameContextLauncherPresenter _gameContextLauncherPresenter;

        [SerializeField] 
        private GameContextCreditsPresenter _gameContextCreditsPresenter;
        
        protected override void Install(IGameContext context)
        {
            _gameContextLauncherPresenter.gameObject.SetActive(true);
            _gameContextCreditsPresenter.gameObject.SetActive(false);
            
            _gameContextLauncherPresenter.buttonStart.onClick.AddListener(() =>
            {
                ApplicationHelper.HideCursor();
                _sceneLoaderComponent.SceneLoaderStartHandler();
            });
            
            _gameContextLauncherPresenter.buttonCredit.onClick.AddListener(() =>
            {
                _gameContextLauncherPresenter.gameObject.SetActive(false);
                _gameContextCreditsPresenter.gameObject.SetActive(true);
            });
            
            _gameContextLauncherPresenter.buttonExit.onClick.AddListener(() =>
            {
                ApplicationHelper.QuitBuildAndEditor();
            });
            
            _gameContextCreditsPresenter.buttonBack.onClick.AddListener(() =>
            {
                _gameContextLauncherPresenter.gameObject.SetActive(true);
                _gameContextCreditsPresenter.gameObject.SetActive(false);
            });

            foreach (var buttonCredit in _gameContextCreditsPresenter.buttonCredits)
            {
                buttonCredit.buttonCredit.onClick.AddListener(() =>
                {
                    ApplicationHelper.OpenURL(buttonCredit.url);
                });
            }

        }
    }
}