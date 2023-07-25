using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextList : MonoBehaviour
{

    private UITextList textList;

    private int lineNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        textList = GetComponent<UITextList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textList.Add("Œ“Õﬂº¶µıÕ‡¥¯"+lineNumber++);
        }
    }
}
