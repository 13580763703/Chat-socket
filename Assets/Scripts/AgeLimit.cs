using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeLimit : MonoBehaviour
{
    private UIInput input;

    void Awake()
    {
        input = this.GetComponent<UIInput>();
    }

    public void OnAgeValueChange()
    {
        string value = input.value;
        int valueint = int.Parse(value);

        if (valueint < 18)
        {
            input.value = "18";
        }

        if (valueint > 120)
        {
            input.value = "120";
        }
    }
}
