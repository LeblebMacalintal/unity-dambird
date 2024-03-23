using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public Text buttonText; // Reference to the text component of the button
    private bool isMuted = false; // Flag to track whether the sound is muted

    void Start()
    {
        // Load mute state from PlayerPrefs or default to false (not muted)
        isMuted = PlayerPrefs.GetInt("IsMuted", 0) == 1;

        // Set the initial text of the button based on the current state
        SetButtonText();

        // Apply the mute state
        ApplyMuteState();
    }

    // Toggle the mute state when the button is clicked
    public void ToggleMute()
    {
        isMuted = !isMuted; // Invert the mute state

        // Apply the mute state
        ApplyMuteState();

        // Update the text of the button
        SetButtonText();
    }

    // Apply the mute state to the audio listener and save to PlayerPrefs
    private void ApplyMuteState()
    {
        // Mute or unmute the audio listener
        AudioListener.pause = isMuted;

        // Save mute state to PlayerPrefs
        PlayerPrefs.SetInt("IsMuted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
    }

    // Set the text of the button based on the current mute state
    void SetButtonText()
    {
        if (isMuted)
        {
            buttonText.text = "Unmute";
        }
        else
        {
            buttonText.text = "Mute";
        }
    }
}
