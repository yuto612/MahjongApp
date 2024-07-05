using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using R3;

namespace MahjongApp
{
    [RequireComponent(typeof(UnityEngine.UI.Button))]
    public class ButtonAsObservable : MonoBehaviour
    {
        public Subject<Unit> onClick = new Subject<Unit>();

        public Observable<Unit> OnClick => onClick;

        // Start is called before the first frame update
        void Start()
        {
            var button = this.GetComponent<Button>();
            button.onClick.AddListener(() => { this.onClick.OnNext(Unit.Default); });
        }


    }
}