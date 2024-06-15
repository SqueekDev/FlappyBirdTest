using System;

public class EndGameScreen : Window
{
    public Action RestartButtonClicked;

    public override void Close() // в видео в этом скрипте он protected, а затем в скрипте Game уже public
    {
        WindowGroup.alpha = 0f;
        ActionButton.interactable = false;
    }

    public override void Open() // в видео в этом скрипте он protected, а затем в скрипте Game уже public
    {
        RestartButtonClicked?.Invoke();
    }

    protected override void OnButtonClick()
    {
        WindowGroup.alpha = 1f;
        ActionButton.interactable = true;
    }
}
