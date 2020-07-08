using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public float fadeOutSpeed = 1.0f;
    public bool destroyable = true;

    public void StartFading(float delayTime)
    {
        if (delayTime > 0)
        {
            StartCoroutine(FadeOutText(delayTime));
        }
        else
        {
            StartCoroutine(FadeOutText());
        }
    }

    public IEnumerator FadeOutText()
    {

        float alpha = 1.0f;

        while (alpha > 0.0f)
        {
            alpha -= fadeOutSpeed * Time.deltaTime;

            text.color = new Color(text.color.r, text.color.g,
                text.color.b, alpha);

            yield return null;
        }

        text.text = "";
        text.color = new Color(text.color.r, text.color.g,
                text.color.b, 1.0f);
        enabled = !destroyable;
    }

    public IEnumerator FadeOutText(float delayTime)
    {

        yield return new WaitForSeconds(delayTime);

        yield return FadeOutText();
    }

    private void OnDisable()
    {
        Destroy(this.gameObject);
    }
}
