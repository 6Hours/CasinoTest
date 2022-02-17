using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;

namespace Test.UI
{
    public class GameController : ScreenControllerBase
    {
        [SerializeField] private AgreementScreen agreementScreen;
        [SerializeField] private AgreementLookScreen agreementLookScreen;
        [SerializeField] private StartScreen startScreen;
        [SerializeField] private GameScreen gameScreen;

        private void Start()
        {
            Initialize();
        }
        public override void Initialize()
        {
            agreementScreen.Initilize();
            agreementLookScreen.Initilize();
            startScreen.Initilize();
            gameScreen.Initilize();

            agreementScreen.OnAgreeClick += () => ChangeCurrentScreen(startScreen);
            agreementScreen.OnShowClick += () => ChangeCurrentScreen(agreementLookScreen);
            agreementLookScreen.OnBack += () => ChangeCurrentScreen(agreementScreen);
            startScreen.OnPlayClick += () => ChangeCurrentScreen(gameScreen);

            currentScreen = agreementScreen;
            agreementScreen.Show();
        }

        private void Exit()
        {
            if (currentScreen == gameScreen) ChangeCurrentScreen(startScreen);
            else Application.Quit();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Exit();
            }
        }
    }
}
