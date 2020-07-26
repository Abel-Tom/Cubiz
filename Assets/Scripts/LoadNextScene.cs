using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
