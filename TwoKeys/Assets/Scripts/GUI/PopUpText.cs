using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpText : MonoBehaviour
{

    [SerializeField]
    private float speed = 1.0f;

    private Vector3 direction;
    private TextMeshProUGUI text;
    private FadeOut fader;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        fader = GetComponent<FadeOut>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Init(Vector3 direction, string text)
    {
        this.direction = direction;
        this.text.text = text;
        StartCoroutine(fader.FadeOutText());
    }

}
