using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;   // SampleScene

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
