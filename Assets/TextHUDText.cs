using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHUDText : MonoBehaviour
{
    public HUDText text;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text.Add(-10, Color.red, 0.1f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            text.Add(+10, Color.green, 0.1f);
        }
    }
}
