using UnityEngine;
using UnityEngine.Video;

public class SkipCutscene : MonoBehaviour
{
    public GameObject CutscenePlayer;
    public GameObject Game;
    public bool isListening = false;
    void Start()
    {

    }

    void Update()
    {
        if (isListening && Input.GetKeyDown(KeyCode.S))
        {
            isListening = false;
            GetComponent<VideoPlayer>().Stop();
            CutscenePlayer.SetActive(false);
            SendMessage("pauseMenuStartListening");
            SendMessage("cameraStartFollowing"); 
            Game.SetActive(true);
        }
    }

    void cutsceneStart()
    {
        isListening = true;
        GetComponent<VideoPlayer>().Play();
    }
}
