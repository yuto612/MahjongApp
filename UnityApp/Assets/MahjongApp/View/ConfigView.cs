using System.Collections;
using System.Collections.Generic;
using R3;
using UnityEngine;

namespace MahjongApp.View
{
    public class ConfigView : MonoBehaviour, IView
    {
        [SerializeField] private ButtonAsObservable returnButton = null;
        public Observable<Unit> OnReturnButton => returnButton.OnClick;

        public bool IsSkip { get; set; } = false;

        public void Hide()
        {
            this.gameObject.SetActive(false);
        }

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
    }
}