using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDesc : MonoBehaviour
{
    [SerializeField] GameObject DescPanel;
    [SerializeField] GameObject Light;
   //public Light lightObj;
    public void TogglePanel()
    {
        DescPanel.SetActive(!DescPanel.activeSelf);
        Light.SetActive(!Light.activeSelf);
       // lightObj.color = Color.blue;

    }
}
