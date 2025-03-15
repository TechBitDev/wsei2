using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Player;



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Player)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Door_o");
        }
    }

    void foundKey()
    {
    }
}
