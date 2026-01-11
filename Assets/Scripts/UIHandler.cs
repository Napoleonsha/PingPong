using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;
    [SerializeField] GameObject gameUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseButton();
        }
    }
    public void PauseButton()
    {
        gameUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void BackToGame()
    {
        gameUI.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        PlayerPrefs.SetInt("BlueScore", 0);
        PlayerPrefs.SetInt("PinkScore", 0);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
