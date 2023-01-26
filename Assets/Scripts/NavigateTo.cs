using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateTo : MonoBehaviour
{
    public void NavigateToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
