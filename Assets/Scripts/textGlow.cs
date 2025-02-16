using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textGlow : MonoBehaviour
{

    [SerializeField] private float minAlpha = 0.1f; // Minimum transparency
    [SerializeField] private float maxAlpha = 1f;   // Maximum transparency
    [SerializeField] private float throbbingSpeed = 2f; // Speed of the throbbing effect

    private TextMeshProUGUI textMeshPro;
    private Color originalColor;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshProUGUI component not found on this GameObject.");
            return;
        }

        originalColor = textMeshPro.color;
        StartCoroutine(ThrobText());
    }

    private IEnumerator ThrobText()
    {
        while (true)
        {
            for (float t = 0; t <= 1; t += Time.deltaTime * throbbingSpeed)
            {
                float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(t, 1));
                textMeshPro.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
                yield return null;
            }

            for (float t = 1; t >= 0; t -= Time.deltaTime * throbbingSpeed)
            {
                float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(t, 1));
                textMeshPro.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
                yield return null;
            }
        }
    }
}
