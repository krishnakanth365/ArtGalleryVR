using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standmanager : MonoBehaviour
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
