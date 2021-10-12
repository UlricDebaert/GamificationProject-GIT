using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UD_ShowValueTesting : MonoBehaviour
{
    Text text;

    public bool isShowingHighscore;

    [Header("Wich Axis ?")]
    public bool isShowingAxisX;
    public bool isShowingAxisY;
    public bool isShowingAxisZ;

    float currentX;
    float currentY;
    float currentZ;

    float highscoreX;
    float highscoreY;
    float highscoreZ;

    void Start()
    {
        text = GetComponent<Text>();

        //InputSystem.EnableDevice(LinearAccelerationSensor.current);

        Input.gyro.enabled = true;
    }


    void Update()
    {
        //currentX = LinearAccelerationSensor.current.acceleration.ReadValue().x;
        //currentY = LinearAccelerationSensor.current.acceleration.ReadValue().y;
        //currentZ = LinearAccelerationSensor.current.acceleration.ReadValue().z;

        currentX = Input.gyro.userAcceleration.x * 100;
        currentY = Input.gyro.userAcceleration.y * 100;
        currentZ = Input.gyro.userAcceleration.z * 100;

        CalculateHighScore();

        if (isShowingHighscore)
        {
            if (isShowingAxisX)
            {
                text.text = highscoreX.ToString();
            }
            if (isShowingAxisY)
            {
                text.text = highscoreY.ToString();
            }
            if (isShowingAxisZ)
            {
                text.text = highscoreZ.ToString();
            }
        }
        else
        {
            if (isShowingAxisX)
            {
                text.text = currentX.ToString();
            }
            if (isShowingAxisY)
            {
                text.text = currentY.ToString();
            }
            if (isShowingAxisZ)
            {
                text.text = currentZ.ToString();
            }
        }
    }

    private void CalculateHighScore()
    {
        if (isShowingAxisX)
        {
            if(currentX >= highscoreX)
            {
                highscoreX = currentX;
            }
        }
        if (isShowingAxisY)
        {
            if (currentY >= highscoreY)
            {
                highscoreY = currentY;
            }
        }
        if (isShowingAxisZ)
        {
            if (currentZ >= highscoreZ)
            {
                highscoreZ = currentZ;
            }
        }
    }
}
