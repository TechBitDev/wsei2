using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class SkipCutscene : MonoBehaviour
{
    public VideoPlayer CutscenePlayer;
    public GameObject CutscenePlayer1;
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
            CutscenePlayer1.SetActive(false);
            Game.SetActive(true);
        }
        
        // if (!CutscenePlayer.isPlaying)
        // {
        //     isListening = false;

        // }
    }

    public void cutsceneStart()
    {
        isListening = true;
        GetComponent<VideoPlayer>().Play();
    }
}
