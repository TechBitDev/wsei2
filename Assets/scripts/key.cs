using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject rend;

    public void ShowKey()
    {
        rend.GetComponent<SpriteRenderer>().enabled = true;
    }
}
