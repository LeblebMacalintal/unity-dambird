using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    public static BackgroundSound instance; // Singleton instance

    public AudioClip backgroundClip; // The audio clip to be played in the background
    private AudioSource audioSource;

    void Awake()
    {
        // Ensure only one instance of BackgroundSound exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist this GameObject between scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
            return;
        }

        // Create an AudioSource component and configure it
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundClip;
        audioSource.loop = true; // Loop the audio clip continuously
        audioSource.volume = 0.5f; // Adjust the volume as needed
        // Play the background sound
        audioSource.Play();
    }
}
