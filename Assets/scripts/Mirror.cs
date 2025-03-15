using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject bg;
    private SpriteRenderer thisSpriteRenderer;
    private SpriteRenderer otherSpriteRenderer;

    void Start()
    {
        thisSpriteRenderer = GetComponent<SpriteRenderer>();

        if (bg != null)
        {
            otherSpriteRenderer = bg.GetComponent<SpriteRenderer>();
        }
    }



    public void OnTriggerEnter2D(Collider2D other)
    {

        // if (collision.gameObject.CompareTag("Player"))
        if (other.gameObject.CompareTag("Player"))
        {
            Sprite tempSprite = thisSpriteRenderer.sprite;
            thisSpriteRenderer.sprite = otherSpriteRenderer.sprite;
            otherSpriteRenderer.sprite = tempSprite;

        }

        // Debug.Log("Attempting sprite swap");
        // Sprite temp = GetComponent<SpriteRenderer>().sprite;
        // GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
        // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite = temp;
        // Debug.Log("Succeeded sprite swap");
        // }
    }
}
