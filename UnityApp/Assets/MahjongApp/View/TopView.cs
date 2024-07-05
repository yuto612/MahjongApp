using System.Collections;
using System.Collections.Generic;
using R3;
using UnityEngine;
using UnityEngine.UI;

namespace MahjongApp.View
{
    public class TopView : MonoBehaviour, IView
    {

        [SerializeField] private ButtonAsObservable configButton = null;
        public Observable<Unit> OnConfigButton => configButton.OnClick;

        [SerializeField] private ButtonAsObservable startButton = null;
        public Observable<Unit> OnStartButton => startButton.OnClick; 
        
        public bool IsSkip { get; set; } = false;

        public void Initialize()
        {
        }

        public void OnStart()
        {

        }

        public void Show()
        {
            this.gameObject.SetActive(true);
        }

        public void Hide()
        {
            this.gameObject.SetActive(false);
        }
    }
}