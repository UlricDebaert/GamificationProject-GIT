using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UD_Timer : MonoBehaviour
{
    private int remainingTime;
    private float timer;
    public int totalTime;

    public bool timerIsRunning;

    public Text timerText;
    public Image timerImage;

    void Start()
    {
        remainingTime = totalTime;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            RunningTimer();
        }

        timerText.text = remainingTime.ToString();
        timerImage.fillAmount = (float)remainingTime / (float)totalTime;
    }

    public void RunningTimer()
    {
        timer += Time.deltaTime;
        remainingTime = totalTime - (int)timer;
    }

    public void StartRunning()
    {
        timerIsRunning = true;
    }

    public void StopRunning()
    {
        timerIsRunning = false;
    }
}
