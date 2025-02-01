using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AtomicGame
{
    public class SceneRestartComponent : MonoBehaviour
    {
        [SerializeField] 
        private float loadingMinimumTime = 2f;
        
        [SerializeField]
        private float loadingWaitAfterComplete = 2f;

        [SerializeField] 
        private bool loadingAutoActivate = true;
        
        private float _loadingTimeCounter;
        private float _loadingProgress;
        private AsyncOperation _asyncOperation;

        
        public virtual string GetSceneName()
        {
            return SceneManager.GetActiveScene().name;
        }
        
        public void SceneLoaderStartHandler()
        {
            if (_asyncOperation == null)
            {
                ApplicationHelper.HideCursor();
                //onStartLoadingScene?.Invoke(EventArgs.Empty);
                StartCoroutine(AsyncSceneLoaderStartHandler());
            }
        }

        private float GetDeltaTime()
        {
            return Time.fixedDeltaTime;//!!! Внимание !!! когда Time.Scale меняется на 0 - то Time.deltaTime не работает, здесь используем fixedTime
        }
        
        public void SceneLoaderActivateHandler()
        {
            if (_asyncOperation != null)
            {
                _asyncOperation.allowSceneActivation = true;
            }
        }
        
        IEnumerator AsyncSceneLoaderStartHandler()
        {
            _loadingTimeCounter = 0;
            _asyncOperation = SceneManager.LoadSceneAsync(GetSceneName());

            _asyncOperation.allowSceneActivation = false;
            while (_asyncOperation.progress < 0.9f)
            {
                _loadingTimeCounter += GetDeltaTime();
                
                _loadingProgress = Mathf.Clamp01(_asyncOperation.progress / 0.9f);

                //onProgressLoadingScene?.Invoke(_loadingProgress);
                
                yield return true;
            }

            if (loadingMinimumTime > 0)
            {
                while (_loadingTimeCounter < loadingMinimumTime)
                {
                    _loadingTimeCounter += GetDeltaTime();
                    yield return true;
                }
            }

            _loadingProgress = 1;
            //onProgressLoadingScene?.Invoke(_loadingProgress);

            if (loadingWaitAfterComplete > 0)
            {
                _loadingTimeCounter = 0;
                while (_loadingTimeCounter < loadingWaitAfterComplete)
                {
                    _loadingTimeCounter += GetDeltaTime();
                    yield return true;
                }
            }
            
            //onFinishLoadingScene?.Invoke(EventArgs.Empty);
            
            ApplicationHelper.ShowCursor();

            if (loadingAutoActivate)
            {
                SceneLoaderActivateHandler();
            }
        }
    }
}