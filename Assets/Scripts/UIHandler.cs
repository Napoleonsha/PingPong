using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;
    [SerializeField] GameObject gameUI;
    public void PauseButton()
    {
        gameUI.SetActive(false);
        pauseUI.SetActive(true);
    }
    public void BackToGame()
    {
        gameUI.SetActive(true);
        pauseUI.SetActive(false);
    }
    public void RestartGame()
    {
        PlayerPrefs.SetInt("BlueScore", 0);
        PlayerPrefs.SetInt("PinkScore", 0);
        SceneManager.LoadScene(0);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
