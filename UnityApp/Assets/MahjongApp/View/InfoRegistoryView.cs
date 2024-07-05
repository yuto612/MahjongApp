using R3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MahjongApp.View
{
    public class InfoRegistoryView : MonoBehaviour, IView
    {
        [SerializeField] private ButtonAsObservable registoriedButton = null;
        public Observable<Unit> OnRegistoryButton => registoriedButton.OnClick;

        public bool IsSkip { get; set; } = false;

        public void Hide()
        {
            this.gameObject.SetActive(false);
        }

        public void Initialize()
        {
            IsSkip = true;
        }

        public void OnStart()
        {
        }

        public void Show()
        {
            this.gameObject.SetActive(true);
        }
    }
}