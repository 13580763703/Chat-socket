using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChatInput : MonoBehaviour
{
    private UIInput input;
    public UITextList textlist;

    private string[] names = new string[4]
    {
        "adgf",
        "siki",
        "adjiowd",
        "wadaija"
    };
    void Awake()
    {
        input = this.GetComponent<UIInput>();
    }
    public void OnChatSubmit()
    {
        string chatMessage = input.value;
        string name = names[Random.Range(0, 4)];
        textlist.Add(name+": "+chatMessage);
        input.value = "";
    }
}
