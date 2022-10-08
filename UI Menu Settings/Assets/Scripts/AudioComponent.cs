using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioComponent : MonoBehaviour
{
    public void ValueChanged(float value)
    {
        Debug.Log("Master & SFX : " + value);
    }

    public void GetToogle(bool value)
    {
        if (value)
        {
            Debug.Log("State true");
        }
        else
        {
            Debug.Log("State false");
        }
    }
}
