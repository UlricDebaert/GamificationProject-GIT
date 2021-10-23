using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UD_MapLocationData : MonoBehaviour
{
    public GameObject closeButton;

    [Header("Infos")]
    public string nomDeLaStation;
    public int nombresAmisInteresses;
    public string evenementPropose;
    public string servicePropose;

    UD_MapLocationInfoPannel pannel;
    Animator pannelAnim;

    private void Start()
    {
        pannel = GameObject.FindGameObjectWithTag("MapInfosPannel").GetComponent<UD_MapLocationInfoPannel>();
        pannelAnim = GameObject.FindGameObjectWithTag("MapInfosPannel").GetComponent<Animator>();
    }

    public void TransmitInfo()
    {
        pannel.ChangePannelInfo(nomDeLaStation, nombresAmisInteresses, evenementPropose, servicePropose);
        pannelAnim.Play("InfoPannel_Opening");
        closeButton.SetActive(true);
    }
}
