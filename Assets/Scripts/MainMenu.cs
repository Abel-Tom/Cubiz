using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
