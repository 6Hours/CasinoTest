using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    public abstract class BaseScreen
    {
        [SerializeField] protected RectTransform screenRect;
        [Tooltip("Optional")]
        [SerializeField] protected Button backButton;
        public abstract void Initilize();
        public virtual void Show()
        {
            screenRect.gameObject.SetActive(true);
        }
        public virtual void Hide()
        {
            screenRect.gameObject.SetActive(false);
        }
    }
}
