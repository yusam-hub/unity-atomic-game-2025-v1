using System;
using UnityEngine;
using UnityEngine.UI;

namespace AtomicGame
{

    [Serializable]
    public struct CreditScruct
    {
        public Button buttonCredit;
        public string url;
    }
    public sealed class GameContextCreditsPresenter : MonoBehaviour
    {
        public GameObject owner;
        
        public Button buttonBack;
        
        public CreditScruct[] buttonCredits;
         
    }
}