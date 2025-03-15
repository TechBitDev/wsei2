using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameOverScreen;
    public void OnTriggerEnter2D(Collider2D other)
    {

        // if (collision.gameObject.CompareTag("Player"))
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("touched enemy");
            SendMessage("playDeathAnimationSkull");
            gameOverScreen.SetActive(true);
            Destroy(GameObject.Find("Player"));
            Debug.Log("aa");

        }

        // Debug.Log("Attempting sprite swap");
        // Sprite temp = GetComponent<SpriteRenderer>().sprite;
        // GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
        // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite = temp;
        // Debug.Log("Succeeded sprite swap");
        // }
    }
}
