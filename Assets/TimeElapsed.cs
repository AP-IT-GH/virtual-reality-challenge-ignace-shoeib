using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    private TextMeshProUGUI text;
    float time = 0;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        text.text = Mathf.RoundToInt(time).ToString()+"\nseconds\nelapsed";
    }
}
