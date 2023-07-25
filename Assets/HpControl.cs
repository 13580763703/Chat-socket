using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpControl : MonoBehaviour
{
    public UISlider slider;
    public UILabel label;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            slider.value -= 0.2f;
        }

        float value = slider.value * 100;
        if (value < 0.5)
            value = 0;
        label.text = value.ToString() + "/100";
    }
}
