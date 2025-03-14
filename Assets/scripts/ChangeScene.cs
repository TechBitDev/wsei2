using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class ChangeScene:MonoBehaviour
    {
        public int numberScene;

        public void changeSceneOnClick()
        {
            SceneManager.LoadScene(numberScene);
        }
    }
}