using UnityEngine;
using UnityEngine.UI;

public class buttonGlow : MonoBehaviour
{
    public float throbSpeed = 1.0f; // Speed of the throb effect
    public float minAlpha = 0.5f; // Minimum transparency
    public float maxAlpha = 1.0f; // Maximum transparency

    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        if (buttonImage == null)
        {
            Debug.LogError("No Image component found on the button.");
        }
    }

    void Update()
    {
        if (buttonImage != null)
        {
            // Calculate alpha
            float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(Time.time * throbSpeed, 1.0f));
            Color color = buttonImage.color;
            color.a = alpha;
            buttonImage.color = color;
        }
    }
}