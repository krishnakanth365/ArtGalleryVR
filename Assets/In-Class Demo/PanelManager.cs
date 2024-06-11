using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject[] Panels;

    private void Start()
    {
        foreach (GameObject obj in Panels) 
        {
            obj.SetActive(false);
        }

    }

   
}
