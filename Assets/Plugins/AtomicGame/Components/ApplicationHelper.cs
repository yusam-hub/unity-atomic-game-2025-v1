using UnityEngine;

namespace AtomicGame
{
    public static class ApplicationHelper
    {
        public static void QuitBuildAndEditor()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
            
        }

        public static void OpenURL(string url)
        {
            Application.OpenURL(url);
        }
        
        public static void Pause()
        {
            Time.timeScale = 0;
        }
        
        public static void Resume()
        {
            Time.timeScale = 1;
        }
        
        public static void HideCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        public static void ShowCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}