using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MahjongApp.View
{
    public interface IView
    {
        public bool IsSkip { get; set; }

        public void OnStart();
        public void Initialize();
        public void Show();
        public void Hide();
    }
}