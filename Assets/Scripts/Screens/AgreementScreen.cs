using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    [Serializable]
    public class AgreementScreen : BaseScreen
    {
        [SerializeField] private Button showTermsOfUse;
        [SerializeField] private Button playButton;
        [SerializeField] private Toggle agreeToggle;

        public Action OnShowClick;
        public Action OnAgreeClick;
        public override void Initilize()
        {
            showTermsOfUse.onClick.AddListener(() => OnShowClick?.Invoke());
            playButton.onClick.AddListener(() =>
            {
                if (agreeToggle.isOn) AgreeClick();
            });
        }

        public override void Show()
        {
            if (PlayerPrefs.GetInt("IsAgreed", 0) == 1) 
            {
                AgreeClick();
                return;
            }
            base.Show();
        }

        private void AgreeClick()
        {
            PlayerPrefs.SetInt("IsAgreed", 1);
            OnAgreeClick?.Invoke();
        }
    }
}
