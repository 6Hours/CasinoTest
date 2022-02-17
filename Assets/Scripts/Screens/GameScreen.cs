using System;
using System.Collections;
using System.Collections.Generic;
using Test.UI.Game;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    [Serializable]
    public class GameScreen : BaseScreen
    {
        [SerializeField] private Button spinButton;
        [SerializeField] private Button autoButton;
        [SerializeField] private Text scoreText;

        [SerializeField] private SlotMachine machine;

        public override void Initilize()
        {
            spinButton.onClick.AddListener(Spin);
            autoButton.onClick.AddListener(SwitchAuto);
            machine.OnRollStart += UpdateScore;
            machine.OnRollEnd += UpdateScore;
        }

        public override void Show()
        {
            base.Show();
            UpdateScore();
        }

        public override void Hide()
        {
            machine.CancelRoll();
            base.Hide();
        }

        private void Spin()
        {
            machine.Roll();
        }

        private void SwitchAuto()
        {
            machine.Auto = !machine.Auto;
            if (machine.IsReady) Spin();
        }

        private void UpdateScore()
        {
            PlayerPrefs.SetInt("Score", machine.Score);
            scoreText.text = machine.Score.ToString();
        }
    }
}
