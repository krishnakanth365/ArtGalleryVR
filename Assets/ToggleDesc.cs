using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDesc : MonoBehaviour
{
    [SerializeField] GameObject DescPanel;
    public void TogglePanel()
    {
        DescPanel.SetActive(!DescPanel.activeSelf);


    }
}
