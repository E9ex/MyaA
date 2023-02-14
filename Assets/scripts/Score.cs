using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;
    public TextMeshProUGUI text;
    private void Start()
    {
        PinCount = 0;
    }

    private void Update()
    {
        text.text = PinCount.ToString();
    }
}
