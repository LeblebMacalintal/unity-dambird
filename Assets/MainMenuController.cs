using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        // Quit the game (only works in builds, not in the editor)
        Application.Quit();
    }
}
