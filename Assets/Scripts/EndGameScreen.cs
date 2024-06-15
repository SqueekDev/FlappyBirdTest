using System;

public class EndGameScreen : Window
{
    public Action RestartButtonClicked;

    public override void Close() // � ����� � ���� ������� �� protected, � ����� � ������� Game ��� public
    {
        WindowGroup.alpha = 0f;
        ActionButton.interactable = false;
    }

    public override void Open() // � ����� � ���� ������� �� protected, � ����� � ������� Game ��� public
    {
        RestartButtonClicked?.Invoke();
    }

    protected override void OnButtonClick()
    {
        WindowGroup.alpha = 1f;
        ActionButton.interactable = true;
    }
}
