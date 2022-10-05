using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    private TextMeshProUGUI textComponent;
    public static float score { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        textComponent.text = Mathf.Floor(score).ToString();
    }
}
