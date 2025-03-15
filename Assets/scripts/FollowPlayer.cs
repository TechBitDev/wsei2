using UnityEngine;

public class Follow_player : MonoBehaviour
{

    public Transform Player;
    private bool following = false;

    void Update()
    {
        if (following && Player != null)
        {
            transform.position = Player.transform.position; //+ new Vector3(0, 1, -5);
        }
    }

    void cameraStartFollowing() 
    {
        following = true;
    }


}