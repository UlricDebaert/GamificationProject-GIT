using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_GameCommonScript : MonoBehaviour
{
    public GameObject selfCanvas;

    public bool thisGameIsActive;

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void StartGame()
    {
        thisGameIsActive = true;

        selfCanvas.SetActive(true);
    }

    public void StopGame()
    {
        thisGameIsActive = false;

        selfCanvas.SetActive(true);
    }
}
