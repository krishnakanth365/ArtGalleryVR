using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform gazeTransform;

    // Start is called before the first frame update
    void Start()
    {
        //gazeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        gazeTransform.localScale = gazeTransform.localScale * 2;

        Debug.Log("Gaze enter");
    }
}
