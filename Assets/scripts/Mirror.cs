using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject bg;
    private SpriteRenderer thisSpriteRenderer;
    private SpriteRenderer bgSpriteRenderer;


    private bool swapped = false;

    void Start()
    {
        thisSpriteRenderer = GetComponent<SpriteRenderer>();

        if (bg != null)
        {
            bgSpriteRenderer = bg.GetComponent<SpriteRenderer>();
        }
    }



    public void OnTriggerEnter2D(Collider2D other)
    {

        // if (collision.gameObject.CompareTag("Player"))
        if (other.gameObject.CompareTag("Player"))
        {
            if (swapped)
            {
                thisSpriteRenderer.sprite = Resources.Load<Sprite>("mirror");
                bgSpriteRenderer.color = Color.white;
            }
            else
            {
                thisSpriteRenderer.sprite = Resources.Load<Sprite>("mirro_purple");
                bgSpriteRenderer.color = new Color(223, 139, 255, 255);
                bgSpriteRenderer.sprite = Resources.Load<Sprite>("bg_castle");
            }
        }

        // Debug.Log("Attempting sprite swap");
        // Sprite temp = GetComponent<SpriteRenderer>().sprite;
        // GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
        // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite = temp;
        // Debug.Log("Succeeded sprite swap");
        // }
    }
}
