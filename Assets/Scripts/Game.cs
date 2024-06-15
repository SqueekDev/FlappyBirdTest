using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EndGameScreen _endScreen;

    private void OnEnable()
    {
        _startScreen.PlayButtonClicked += OnPlayerButtonClick;
        _endScreen.RestartButtonClicked += OnRestartButtonClick;
        //_bird.GameOver += OnGameOver;
    }

    //private void Start()
    //{
    //    Time.timeScale = 0;
    //    _startScreen.Open();
    //}

    private void OnDisable()
    {
        _startScreen.PlayButtonClicked -= OnPlayerButtonClick;
        _endScreen.RestartButtonClicked -= OnRestartButtonClick;
        //_bird.GameOver -= OnGameOver;
    }

    //private void OnGameOver()
    //{
    //    Time.timeScale = 0;
    //    _endScreen.Open();
    //}

    private void OnRestartButtonClick()
    {
        _endScreen.Close();
        StartGame();
    }

    private void OnPlayerButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _bird.Reset();
    }
}
