using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_StartGame : MonoBehaviour
{
    public UD_Timer timer;

    public void StartGameButton()
    {
        timer.StartRunning();
        gameObject.SetActive(false);
    }
}
