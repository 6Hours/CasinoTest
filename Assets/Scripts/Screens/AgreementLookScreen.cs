using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    [Serializable]
    public class AgreementLookScreen : BaseScreen
    {
        public Action OnBack;
        public override void Initilize()
        {
            backButton.onClick.AddListener(() => OnBack?.Invoke());
        }
    }
}
