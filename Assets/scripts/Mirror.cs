using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject bg;
    private SpriteRenderer thisSpriteRenderer;
    private SpriteRenderer bgSpriteRenderer;

    byte touchCounter = 0;


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
                bgSpriteRenderer.sprite = Resources.Load<Sprite>("bg_castle2");
                // bgSpriteRenderer.color = Color.white;
                Debug.Log("asaaaa");
            }
            else
            {
                thisSpriteRenderer.sprite = Resources.Load<Sprite>("mirro_purple");
                // bgSpriteRenderer.color = new Color(223, 139, 255, 255);
                bgSpriteRenderer.sprite = Resources.Load<Sprite>("bg_castle");
                Debug.Log("ba");
            }
            swapped = !swapped;
            touchCounter++;

            if (touchCounter == 3)
            {
                SendMessage("ShowKey");
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
