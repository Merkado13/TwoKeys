using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{
    [SerializeField]
    private float fadeOutSpeed = 1.0f;
    [SerializeField]
    private float speed = 1.0f;


    private Vector3 direction;
    private TextMesh text;

    private void Awake()
    {
        text = GetComponent<TextMesh>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(Vector3 direction, string text)
    {
        this.direction = direction;
        this.text.text = text;
        StartCoroutine(FadePopUpText());
    }

    public IEnumerator FadePopUpText()
    {

        float alpha = 1.0f;

        while (alpha > 0.0f)
        {
            transform.Translate(direction * speed * Time.deltaTime);
            alpha -= fadeOutSpeed * Time.deltaTime;

            text.color = new Color(text.color.r, text.color.g, 
                text.color.b, alpha);

            yield return null;
        }

        enabled = false;
    }

    private void OnDisable()
    {
        Destroy(this.gameObject);
    }
}
