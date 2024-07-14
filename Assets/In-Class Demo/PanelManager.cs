using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
   
    public GameObject[] Panels;
    public GameObject[] Pieces;

    private void Start()
    {
        foreach (GameObject obj in Panels) 
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in Pieces)
        {
            obj.SetActive(false);
        }

    }

}
