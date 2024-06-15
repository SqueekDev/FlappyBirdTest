using System;

public class StartScreen : Window
{
    public event Action PlayButtonClicked;

    public override void Close() // в видео в этом скрипте он protected, а затем в скрипте Game уже public
    {
        WindowGroup.alpha = 0f;
        ActionButton.interactable = false;
    }

    public override void Open() // в видео в этом скрипте он protected, а затем в скрипте Game уже public
    {
        WindowGroup.alpha = 1f;
        ActionButton.interactable = true;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClicked?.Invoke();
    }
}
