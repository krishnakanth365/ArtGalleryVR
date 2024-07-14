using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posUpdate : MonoBehaviour
{
    public GameObject character;
    public GameObject Collider;
    private void Update()
    {
        Collider.transform.position= character.transform.position;  
    }
}
