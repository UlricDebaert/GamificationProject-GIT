using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_ShopAchat : MonoBehaviour
{
    private int currentPoint;

    void Start()
    {
        currentPoint = PlayerPrefs.GetInt("totalPoint");
    }

    public void Buy(int price)
    {
        currentPoint -= price;
        PlayerPrefs.SetInt("totalPoint", currentPoint);
    }
}
