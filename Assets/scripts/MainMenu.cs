using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject pauseMenuUi;
    public GameObject game;
    public GameObject CutscenePlayer;
    public Button OptionsBackButton;

    void Start()
    {
        Debug.Log("Loaded");
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Debug.Log("Starting New Game - Play");
        Time.timeScale = 1f;
        SendMessage("cutsceneStart");
        CutscenePlayer.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void Options() {
        Debug.Log("Opening Options");
        mainMenuUI.SetActive(false);
        OptionsBackButton.onClick.AddListener(BackToMainMenu);
    }

    public void BackToMainMenu() {
        Debug.Log("Back To Main Menu");
        mainMenuUI.SetActive(true);
        OptionsBackButton.onClick.RemoveListener(BackToMainMenu);
    }

    // QuitButton onClick is in PauseMenu
}
