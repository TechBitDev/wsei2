using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameOverScreen;
    public void OnTriggerEnter2D(Collider2D other)
    {

        // if (collision.gameObject.CompareTag("Player"))
        if (other.gameObject.CompareTag("Player"))
        {
            SendMessageUpwards("playDeathAnimationSkull");
            SendMessageUpwards("cameraStopFollowing");
            gameOverScreen.SetActive(true);
            Destroy(GameObject.Find("Player"));
            Debug.Log("killed player");

        }

        // Debug.Log("Attempting sprite swap");
        // Sprite temp = GetComponent<SpriteRenderer>().sprite;
        // GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
        // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite = temp;
        // Debug.Log("Succeeded sprite swap");
        // }
    }
}
