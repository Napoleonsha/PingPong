
using UnityEngine;


public class Settings : MonoBehaviour
{
    private string fullScreenToggle = "Fullscreen";
    void Start()
    {
        bool isFullScreen = PlayerPrefs.GetInt(fullScreenToggle, 1) == 1;
        Screen.fullScreen = isFullScreen;
    }
    public void FullScreen(bool value)
    {
        Screen.fullScreen = !Screen.fullScreen;
        PlayerPrefs.SetInt(fullScreenToggle, Screen.fullScreen ? 1 : 0);
        PlayerPrefs.Save();
    }

}