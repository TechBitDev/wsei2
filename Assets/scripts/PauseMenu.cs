using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] public static bool isListening = false;
    public GameObject pauseMenuUI;
    public Button OptionsBackButton;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isListening)
        {
            if (isPaused)
            {
                Resume();

            } else {
                Pause();
            }
        }
    }

    void pauseMenuStartListening() {
        isListening = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Pausing");
        isPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Resuming");
        isPaused = false;
    }

    public void Options() {
        Debug.Log("Opening Options");
        isListening = false;
        pauseMenuUI.SetActive(false);
        OptionsBackButton.onClick.AddListener(BackToPauseMenu);
    }

    public void BackToPauseMenu() {
        Debug.Log("Back To Main Menu");
        isListening = true;
        pauseMenuUI.SetActive(true);
        OptionsBackButton.onClick.RemoveListener(BackToPauseMenu);
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }


}
