using System.Collections;
using System.Collections.Generic;
using MahjongApp;
using MahjongApp.View;
using R3;
using UnityEngine;

public class ResultView : MonoBehaviour, IView
{
    [SerializeField] private ButtonAsObservable rereadButton = null;
    public Observable<Unit> OnRereadButton => rereadButton.OnClick;

    [SerializeField] private ButtonAsObservable returnTopButton = null;
    public Observable<Unit> OnReturnTopButton => returnTopButton.OnClick;

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
