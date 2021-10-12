using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_ShopPoints : MonoBehaviour
{
    private int currentPoint;

    void Start()
    {
        currentPoint = PlayerPrefs.GetInt("totalPoint");
    }
    
    public void AddPoints(int point)
    {
        currentPoint += point;
        PlayerPrefs.SetInt("totalPoint", currentPoint);
    }

    public int GetTotalPoint()
    {
        return currentPoint;
    }
}
