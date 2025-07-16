using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int seconds = 10;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (seconds > 0)
        {
            timerText.text = seconds.ToString();
            yield return new WaitForSeconds(1f);
            seconds--;
        }
        timerText.text = "GO!";
    }
}

