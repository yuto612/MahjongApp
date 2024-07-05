using System.Collections;
using System.Collections.Generic;
using MahjongApp;
using MahjongApp.View;
using R3;
using UnityEngine;

public class ReadView : MonoBehaviour,IView
{
    // Œã‚ÉA”F¯Œã‚É‘JˆÚ‚É•ÏX‚É‚È‚é‚½‚ßíœ—\’è
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
