using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject Skull2;
    
    void Update()
    {
        if (Time.frameCount % 20 == 0)
        {
            Skull2.SetActive(!Skull2.activeSelf);
        }
    }

    void playDeathAnimationSkull() 
    {
        Time.timeScale = 0f;
        SendMessage("pauseMenuStopListening");
        gameOverScreen.SetActive(true);
        
        // Animator animator = GetComponent<Animator>();
        // animator.Play("Laugh");
    }
}
