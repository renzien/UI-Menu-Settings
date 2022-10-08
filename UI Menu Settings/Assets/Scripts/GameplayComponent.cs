using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayComponent : MonoBehaviour
{
    [SerializeField] TMP_Dropdown drop;

    public void GetOption(int value)
    {
        Debug.Log("Quality : " + drop.options[value].text);
    }

    public void ValueChanged(float value)
    {
        Debug.Log("Text Speed : " + value);
    }
}
