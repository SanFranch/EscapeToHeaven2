using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEvent : MonoBehaviour
{
    [SerializeField] Animator InterruttoreAnimator;
    [SerializeField] bool Off;

    public void TryOpen()
    {
        if(!Off)
        {
            if(InterruttoreAnimator.GetBool("interact") == false)
            {
                InterruttoreAnimator.SetBool("interact", true);
            }
            else
            {
                InterruttoreAnimator.SetBool("interact", false);
            }
        }
    }
    public void Unlock()
    {
        Off = false;
    }
}
