using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UD_MapLocationInfoPannel : MonoBehaviour
{
    public TMP_Text nomAire;
    public TMP_Text nombreAmisInteresses;
    public TMP_Text evenementPropose;
    public TMP_Text servicesProposes;

    Animator pannelAnim;

    private void Start()
    {
        pannelAnim = GetComponent<Animator>();
    }

    public void ChangePannelInfo(string nom, int nbAmis, string evenement, string services)
    {
        nomAire.text = nom;
        nombreAmisInteresses.text = nbAmis.ToString();
        evenementPropose.text = evenement;
        servicesProposes.text = services;
    }

    public void HideInfos()
    {
        pannelAnim.Play("InfoPannel_Closing");
    }
}
