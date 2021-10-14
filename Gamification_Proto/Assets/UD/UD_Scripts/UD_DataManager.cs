using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_DataManager : MonoBehaviour
{
    public float currentPoints;

    public static string[] earningString;
    public static string[] earningCodeString;

    void Start()
    {
        currentPoints = PlayerPrefs.GetInt("totalPoint");
    }


    void Update()
    {
        
    }
}
