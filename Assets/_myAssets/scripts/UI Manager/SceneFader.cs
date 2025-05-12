using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public Image fadeImage;

    private void Awake()
    {
        fadeImage = GetComponent<Image>();

    }

    public IEnumerator FadeIn(float duration)
    {
        Color startColor = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);

        Color endColor = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0);

        yield return FadeCoroutine(startColor, endColor, duration);

        gameObject.SetActive(false);
    }

    public IEnumerator FadeOut(float duration)
    {
        Color startColor = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0);

        Color endColor = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);

        gameObject.SetActive(true);

        yield return FadeCoroutine(startColor, endColor, duration);

    }

    private IEnumerator FadeCoroutine(Color startColor, Color endColor, float duration)
    {
        float elapsedTime = 0;
        float elapsedPErcent = 0;

        while (elapsedPErcent < 1)
        {
            elapsedPErcent = elapsedTime / duration;
            fadeImage.color = Color.Lerp(startColor, endColor, elapsedPErcent);

            yield return null;

            elapsedTime += Time.deltaTime;
        }

    }
}
