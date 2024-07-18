using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeaterEvent : MonoBehaviour
{
    [SerializeField] LightEvent Light;

    public void OnRepeater()
    {
        Light.Unlock();
        Destroy(gameObject);
    }
}
