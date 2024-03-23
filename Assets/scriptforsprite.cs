using UnityEngine;

public class AnimatedBackground : MonoBehaviour
{
    public int startFrameIndex = 0; // Starting index of the frames
    public int endFrameIndex = 142; // Ending index of the frames
    public string frameNameFormat = "frame{0:D4}"; // Format of the frame names (e.g., "frame0000")
    public float framesPerSecond = 24f; // Frames per second for the animation
    private SpriteRenderer spriteRenderer;
    private Sprite[] frames;
    private int currentFrameIndex = 0;
    private float frameTimer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        LoadFrames();
    }

    void LoadFrames()
    {
        int frameCount = endFrameIndex - startFrameIndex + 1;
        frames = new Sprite[frameCount];

        for (int i = 0; i < frameCount; i++)
        {
            string frameName = string.Format(frameNameFormat, startFrameIndex + i);
            frames[i] = Resources.Load<Sprite>(frameName);

            if (frames[i] == null)
            {
                Debug.LogError("Frame not found: " + frameName);
                enabled = false;
                return;
            }
        }
    }

    void Update()
    {
        // Calculate time per frame
        float timePerFrame = 1f / framesPerSecond;

        // Increment frame timer
        frameTimer += Time.deltaTime;

        // If it's time to change frame, update sprite
        if (frameTimer >= timePerFrame)
        {
            currentFrameIndex = (currentFrameIndex + 1) % frames.Length;
            spriteRenderer.sprite = frames[currentFrameIndex];
            frameTimer -= timePerFrame;
        }
    }
}
