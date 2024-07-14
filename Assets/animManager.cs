using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animManager : MonoBehaviour
{
    public Animator doorAnimator;
    public int num = 0;
    public void IncNumber()
    {
        num++;

    }

    private void Update()
    {
        if(num>= 7)
        {
            doorAnimator.Play("Door Anim");
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //if (other.CompareTag("Player"))
    //    {
    //        doorAnimator.Play("Door Anim");
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //  // if (other.CompareTag("Player"))
    //    {
    //        doorAnimator.Play("Door Close");
    //    }
    //}
}
