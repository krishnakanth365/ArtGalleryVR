using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationScript : MonoBehaviour
{
    // Public variables to set the positions
    public Vector3 offScreenPosition;
    public Vector3 onScreenPosition;

    // Duration of the lerp
    public float lerpDuration = 1.0f;
    public float onScreenDuration = 3.0f;

    // Private variables to track the lerp state
    private RectTransform rectTransform;
    private bool isLerping = false;
    private bool isReturning = false;
    private float lerpStartTime;

    private void Start()
    {
        // Get the RectTransform component
        rectTransform = GetComponent<RectTransform>();

        // Set the initial position to be off-screen
        rectTransform.anchoredPosition = offScreenPosition;
    }

    private void Update()
    {
        if (isLerping)
        {
            // Calculate the lerp progress
            float timeSinceStarted = Time.time - lerpStartTime;
            float percentageComplete = timeSinceStarted / lerpDuration;

            // Perform the lerp
            if (!isReturning)
            {
                rectTransform.anchoredPosition = Vector3.Lerp(offScreenPosition, onScreenPosition, percentageComplete);

                // Check if the lerp to on-screen is complete
                if (percentageComplete >= 1.0f)
                {
                    isLerping = false;
                    Invoke("StartReturnLerp", onScreenDuration);
                }
            }
            else
            {
                rectTransform.anchoredPosition = Vector3.Lerp(onScreenPosition, offScreenPosition, percentageComplete);

                // Check if the lerp to off-screen is complete
                if (percentageComplete >= 1.0f)
                {
                    isLerping = false;
                    isReturning = false;
                }
            }
        }
    }

    // Public function to start the lerp
    public void StartLerp()
    {
        isLerping = true;
        isReturning = false;
        lerpStartTime = Time.time;
    }

    // Function to start the return lerp
    private void StartReturnLerp()
    {
        isLerping = true;
        isReturning = true;
        lerpStartTime = Time.time;
    }
}
