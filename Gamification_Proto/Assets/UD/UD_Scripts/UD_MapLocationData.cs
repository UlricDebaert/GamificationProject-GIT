using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UD_MapLocationData : MonoBehaviour
{
    public GameObject closeButton;
    public Image activityIcon;

    [Header("Infos")]
    public string nomDeLaStation;
    //public int nombresAmisInteresses;
    //public string evenementPropose;
    //public string servicePropose;
    public Sprite infosSprite;

    UD_MapLocationInfoPannel pannel;
    Animator pannelAnim;

    private void Start()
    {
        pannel = GameObject.FindGameObjectWithTag("MapInfosPannel").GetComponent<UD_MapLocationInfoPannel>();
        pannelAnim = GameObject.FindGameObjectWithTag("MapInfosPannel").GetComponent<Animator>();
    }

    public void TransmitInfo()
    {
        //pannel.ChangePannelInfo(nomDeLaStation, nombresAmisInteresses, evenementPropose, servicePropose);
        pannel.ChangePannelInfo(nomDeLaStation);
        activityIcon.sprite = infosSprite;
        pannelAnim.Play("InfoPannel_Opening");
        closeButton.SetActive(true);
    }
}
