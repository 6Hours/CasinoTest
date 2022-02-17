using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.UI
{
    public abstract class ScreenControllerBase : MonoBehaviour
    {
        protected BaseScreen currentScreen;

        public abstract void Initialize();

        public virtual void ChangeCurrentScreen(BaseScreen screen)
        {
            currentScreen.Hide();
            currentScreen = screen;
            currentScreen.Show();
        }
    }
}
