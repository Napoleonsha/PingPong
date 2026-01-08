using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject settingsUI;
    [SerializeField] GameObject mainMenuUI;

    public void MainMenuOpen()
    {
        settingsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void SettingsOpen()
    {
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    public void NewGame()
    {
        PlayerPrefs.SetInt("BlueScore", 0);
        PlayerPrefs.SetInt("PinkScore", 0);
        SceneManager.LoadScene(0);
    }

    public void ContinueGame()
    {
        PlayerPrefs.GetInt("BlueScore", 0);
        PlayerPrefs.GetInt("PinkScore", 0);
        SceneManager.LoadScene(0);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
}
