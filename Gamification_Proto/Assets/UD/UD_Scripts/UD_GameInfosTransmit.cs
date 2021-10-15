using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UD_GameInfosTransmit : MonoBehaviour
{
    public string instructionToShow;
    public Sprite imageToShow;

    public TMP_Text instruction;
    public Image activityImage;

    public void TransmitInfo()
    {
        instruction.text = instructionToShow;
        activityImage.sprite = imageToShow;
    }

}
