using UnityEngine;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    public Button unpauseButton;
    public Button exitButton;

    private bool isPopupOpen = false;

    void Start()
    {
        // Hide the unpause and exit buttons initially
        unpauseButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    public void TogglePopup()
    {
        isPopupOpen = !isPopupOpen;

        if (isPopupOpen)
        {
            // Show the unpause and exit buttons
            unpauseButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }
        else
        {
            // Hide the unpause and exit buttons
            unpauseButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(false);
        }
    }

    public void Unpause()
    {
        // Resume the game
        Time.timeScale = 1f;
        TogglePopup();
    }

    public void ExitGame()
    {
        // Exit the game
        Debug.Log("Exitting game...");
        Application.Quit();
    }
}
