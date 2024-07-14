using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleDesc : MonoBehaviour
{

    public lookAt lookAt;
    public NotificationScript notification;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject DescPanel;
    [SerializeField] GameObject Light;
    [SerializeField] GameObject Letters;


    public void TurnOnLights(int i)
    {
        if (lookAt.CanAct(i))
        {
            DescPanel.SetActive(!DescPanel.activeSelf);
            Light.SetActive(!Light.activeSelf);
            lookAt.IsCorrect(i);
            Letters.SetActive(true);
        }

        else
        {
            Debug.Log("Go to :" + (lookAt.CorrectStand + 1));
            text.text = "Please go to : " + (lookAt.CorrectStand + 1);
            notification.StartLerp();
        }
    }

}
