using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField] private Bird _bird;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GameScreen _gameScreen;
    [SerializeField] private EndScreen _endScreen;
    [SerializeField] private PauseScreen _pauseScreen;

    private void Awake()
    {
        _endScreen.gameObject.SetActive(false);
        _gameScreen.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _bird.GameOver += GameOver;
        _startScreen.PlayButtonCliked += StartGame;
        _gameScreen.PauseButtonCliked += PauseGame;
        _endScreen.EndButtonCliked += RestartGame;
        _pauseScreen.ExitCliked += ExitGame;
        _pauseScreen.Continue += ContinueGame;

    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void ContinueGame()
    {
        Time.timeScale = 1f;
        _pauseScreen.gameObject.SetActive(false);
    }

    private void GameOver()
    {
        _endScreen.gameObject.SetActive(true);
        _pipeGenerator.StopSpawnPipe();
    }

    private void StartGame()
    {
        _startScreen.gameObject.SetActive(false);
        _gameScreen.gameObject.SetActive(true);
        _bird.gameObject.SetActive(true);
        _pipeGenerator.SartSpawnPipe();
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        _pauseScreen.gameObject.SetActive(true);
    }

    private void RestartGame()
    {
        _bird.Reset();
        _endScreen.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        _bird.GameOver -= GameOver;
        _startScreen.PlayButtonCliked -= StartGame;
        _gameScreen.PauseButtonCliked -= PauseGame;
        _endScreen.EndButtonCliked -= RestartGame;
        _pauseScreen.ExitCliked -= ExitGame;
        _pauseScreen.Continue -= ContinueGame;
    }
}
