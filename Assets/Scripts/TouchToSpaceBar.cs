using UnityEngine;

public class TouchToSpaceBar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if there is any touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            // Check if the touch phase is began (finger touches the screen)
            if (touch.phase == TouchPhase.Began)
            {
                // Simulate space bar press
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // Do something if space bar is already pressed
                }
                else
                {
                    // Simulate pressing space bar
                    InputSimulator.KeyPress(KeyCode.Space);
                }
            }
        }
    }
}
