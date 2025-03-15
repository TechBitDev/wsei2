using UnityEngine;

public class World : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject Game;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainMenuUI.SetActive(true);
        Game.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeDimensions(string portalObjectName) {
        // Debug.Log("Attempting sprite swap");
        // Sprite temp = GameObject.Find(portalObjectName).GetComponent<SpriteRenderer>().sprite;
        // GameObject.Find(portalObjectName).GetComponent<SpriteRenderer>().sprite = GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite;
        // GameObject.FindWithTag("Background").GetComponent<SpriteRenderer>().sprite  = temp;
        // Debug.Log("Succeeded sprite swap");
    }
}
