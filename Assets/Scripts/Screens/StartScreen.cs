using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    [Serializable]
    public class StartScreen : BaseScreen
    {
        [SerializeField] private Button playButton;

        public Action OnPlayClick;
        public override void Initilize()
        {
            playButton.onClick.AddListener(() => OnPlayClick?.Invoke());
            backButton.onClick.AddListener(() => Application.Quit());
        }
    }
}
