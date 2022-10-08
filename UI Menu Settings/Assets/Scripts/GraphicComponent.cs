using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GraphicComponent : MonoBehaviour
{
    [SerializeField] TMP_Dropdown drop;


    public void GetOption(int value)
    {
        Debug.Log("Quality : " + drop.options[value].text);
    }

    public void ValueChanged(float value)
    {
        Debug.Log("Brightness & Gamma : " + value);
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
