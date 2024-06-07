using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ToggleDescription : MonoBehaviour
{
    public GameObject description;
    private void Start()
    {
        description.SetActive(false);
    }
    

    public void ToggleActive()
    {
        description.SetActive(!description.activeSelf);
    }
}
