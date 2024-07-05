using System.Collections;
using System.Collections.Generic;
using MahjongApp;
using MahjongApp.View;
using R3;
using UnityEngine;

public class ReadView : MonoBehaviour,IView
{
    // ��ɁA�F����ɑJ�ڂɕύX�ɂȂ邽�ߍ폜�\��
    [SerializeField] private ButtonAsObservable readButton = null;
    public Observable<Unit> OnReadButton => readButton.OnClick;

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
