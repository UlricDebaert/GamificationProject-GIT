using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_ChooseGame : MonoBehaviour
{
    public string[] validationCode;

    //public UD_GameCommonScript[] miniGameScript;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void ValidateCode(string enteredCode)
    {
        for(int i=0; i<validationCode.Length; i++)
        {
            if(enteredCode == validationCode[i])
            {
                //ChooseRandomGame();

            }
        }
    }

    //void ChooseRandomGame()
    //{
    //    int rand = Random.Range(0, miniGameScript.Length);

    //    miniGameScript[rand].StartGame();
    //}
}
