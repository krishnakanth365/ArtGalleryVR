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
        description.GetComponent<CanvasRenderer>().SetAlpha(0f);
    }
    

    public void ToggleActive()
    {
        description.GetComponent<CanvasRenderer>().SetAlpha(1f);
        description.SetActive(!description.activeSelf);
    }
}
