using UnityEngine;
using UnityEngine.SceneManagement;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneLoader : MonoBehaviour
{
    public void LoadToScene(string sceneName)
    {
        UnitySceneManager.LoadScene(sceneName);
    }
}