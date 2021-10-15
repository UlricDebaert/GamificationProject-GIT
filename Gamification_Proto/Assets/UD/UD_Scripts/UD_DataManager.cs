using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_DataManager : MonoBehaviour
{
    //public float currentPoints;

    //public static string[] earningString;
    //public static string[] earningCodeString;

    public int numberUsingDay;
    public int numberExerciceFinished;

    public static string[] friendNameList;

    void Start()
    {
        //currentPoints = PlayerPrefs.GetInt("totalPoint");

        numberUsingDay = PlayerPrefs.GetInt("numberUsingDay");
        numberExerciceFinished = PlayerPrefs.GetInt("numberExerciceFinished");
    }
}
