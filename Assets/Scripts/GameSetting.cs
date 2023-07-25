using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameGrade
{
    EASY,
    NORMAL,
    DIFFCULTY
}

public enum ControlType
{
    KEYBOARD,
    TOUCH,
    MOUSE
}

public class GameSetting : MonoBehaviour
{
    public float volume = 1;
    public GameGrade grade = GameGrade.NORMAL;
    public ControlType controlType = ControlType.MOUSE;
    public bool isFullScreen = false;

    public TweenPosition startPanelTween;
    public TweenPosition optionPanelTween;
    public void OnvolumeChanged()
    {
        print("volume"+UIProgressBar.current.value);
        volume = UIProgressBar.current.value;
    }

    public void OnGameGradeChanged()
    {
        print("gamegrade"+ UIPopupList.current.value);
        switch (UIPopupList.current.value.Trim())
        {
            case "简单":
                grade = GameGrade.EASY;
                break;
            case "普通":
                grade = GameGrade.NORMAL;
                break;
            case "困难":
                grade = GameGrade.DIFFCULTY;
                break;
        }
    }

    public void OnControlChanged()
    {
        print("control"+UIPopupList.current.value);
        switch (UIPopupList.current.value.Trim())
        {
            case "鼠标":
                controlType = ControlType.MOUSE;
                break;
            case "键盘":
                controlType = ControlType.KEYBOARD;
                break;
            case "手柄":
                controlType = ControlType.TOUCH;
                break;
        }
    }

    public void OnIsFullChanged()
    {
        print("isfullscreen"+UIToggle.current.value);
        if (UIToggle.current.value == true)
            isFullScreen = true;
        else
        {
            isFullScreen = false;
        }
    }

    public void OnOptionButtonClick()
    {
        startPanelTween.PlayForward();
        optionPanelTween.PlayForward();
    }

    public void OnCompleteSettingButton()
    {
        startPanelTween.PlayReverse();
        optionPanelTween.PlayReverse();
    }
}
