using UnityEngine;
using UnityEngine.UI;

public abstract class Window : MonoBehaviour
{
    [SerializeField] private CanvasGroup _windowGroup;
    [SerializeField] private Button _actionButton;

    protected CanvasGroup WindowGroup => _windowGroup;
    protected Button ActionButton => _actionButton;

    private void OnEnable()
    {
        _actionButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _actionButton.onClick.RemoveListener(OnButtonClick);        
    }

    public abstract void Open(); // в видео он не был показан в этом скрипте, только в дочерних, так же в видео он protected, а затем в скрипте Game уже public

    public abstract void Close(); // в видео он не был показан в этом скрипте, только в дочерних, так же в видео он protected, а затем в скрипте Game уже public

    protected abstract void OnButtonClick();
}
