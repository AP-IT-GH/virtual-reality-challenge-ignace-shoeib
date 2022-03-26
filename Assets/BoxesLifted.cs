using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxesLifted : MonoBehaviour
{
    private int lifted = 0;
    private TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void IncreaseLift()
    {
        lifted++;
        text.text = lifted.ToString() + "\nboxes\nlifted";
    }
}
