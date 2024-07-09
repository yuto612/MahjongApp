using System.Collections;
using System.Collections.Generic;
using MahjongApp.View;
using UnityEngine;
using R3;

public class ViewManager : MonoBehaviour
{
    [SerializeField] private TopView topView = null;
    [SerializeField] private ConfigView configView = null;
    [SerializeField] private ReadView readView = null;
    [SerializeField] private ResultView resultView = null;

    // Start is called before the first frame update
    void Start()
    {
        OnStartViews();
        HideAll();

        ShowView(topView);

        SubscribeEvents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowView(IView view)
    {
        view.Show();
    }

    private void Next(IView currentView ,IView nextView)
    {
        currentView.Hide();

        nextView.Initialize();
        nextView.Show();
    }

    private void HideAll()
    {
        topView.Hide();
        configView.Hide();
        readView.Hide();
        resultView.Hide();
    }

    private void OnStartViews()
    {
        topView.OnStart();
        configView.OnStart();
        readView.OnStart();
        resultView.OnStart();
    }

    private void SubscribeEvents()
    {
        topView.OnConfigButton.Subscribe(_ =>
        {
            Next(topView, configView);
        }).AddTo(this);

        topView.OnStartButton.Subscribe(_ =>
        {
                Next(topView, readView);
        }).AddTo(this);

        configView.OnReturnButton.Subscribe(_ =>
        {
            Next(configView,topView);
        }).AddTo(this);

        readView.OnReadButton.Subscribe(_ =>
        {
            // GPT‚ÌŒvŽZ‚ª“ü‚é

            // await...
            Next(readView, resultView);
        }).AddTo(this);

        resultView.OnRereadButton.Subscribe(_ =>
        {
            Next(resultView, readView);
        }).AddTo(this);

        resultView.OnReturnTopButton.Subscribe(_ =>
        {
            Next(resultView,topView);
        }).AddTo(this);
    }
}
