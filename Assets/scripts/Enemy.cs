using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameOverScreen;

    byte touchCounter = 0;
    public void OnTriggerEnter2D(Collider2D other)
    {

        // if (collision.gameObject.CompareTag("Player"))
        if (other.gameObject.CompareTag("Player"))
        {
            touchCounter++;

            if (touchCounter == 4)
            {
                SendMessageUpwards("playDeathAnimationSkull");
                SendMessageUpwards("cameraStopFollowing");
                gameOverScreen.SetActive(true);
                Destroy(GameObject.Find("Player"));
                Debug.Log("killed player");
            }

        }

    }

    public void ShowKey()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        transform.position -= new Vector3(4, 0, 0);
    }




    // Debug.Log("Attempting sprite swap");
    // Sprite temp = GetComponent<SpriteRenderer>().sprite;
    // GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
    // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite = temp;
    // Debug.Log("Succeeded sprite swap");
    // }
}

