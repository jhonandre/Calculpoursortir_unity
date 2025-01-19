using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public int StartCount = 60;
    private TMP_Text timeText;

    void Start()
    {
        timeText = GameObject.Find("Timer").GetComponent<TMP_Text>();
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (StartCount > 0)
        {
            yield return new WaitForSeconds(1f);
            StartCount--;
            timeText.text = "TimeLeft :" + StartCount;
        }
        if (StartCount <= 0)
        {
            SceneManager.LoadScene("GameOver");

            
        }
    }
}
