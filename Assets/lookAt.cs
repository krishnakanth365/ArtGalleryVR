using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public int CorrectStand;

    public bool[] Checks = new bool[7];

    private void Start()
    {
        for (int i = 0; i < Checks.Length; i++)
        {
            Checks[i] = false;
        }

        Checks[0] = true;

    }
    private void Update()
    {
        FindTrueBoolean();
    }


    void FindTrueBoolean()
    {
        // Iterate through the array to find the true boolean
        for (int i = 0; i < Checks.Length; i++)
        {
            if (Checks[i])
            {
                CorrectStand = i;
                //   Debug.Log("Correct stand:" + i);
                return;
            }
        }
    }


    public bool CanAct(int i)
    {
        if (Checks[i] == true)
        {
            return true;
        }
        else
            return false;
    }

    public void IsCorrect(int i)
    {
        if (i < 0 || i >= Checks.Length - 1) // Added boundary check
        {
            // Debug.LogWarning("Index out of bounds.");
            return;
        }
        Checks[i] = false;

        Checks[i + 1] = true;
    }



}
