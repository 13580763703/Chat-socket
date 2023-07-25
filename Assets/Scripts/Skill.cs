using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float coldTime = 22;
    private float cd;

    private bool colding = false;
    private UISprite sprite;
    private UILabel label;
    void Awake()
    {
        sprite = transform.Find("Sprite").GetComponent<UISprite>();
        label = transform.Find("Label").GetComponent<UILabel>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && colding==false)
        {
            //1.�ͷż��� ��������ϵͳ ��ʾ������Ч
            //2.ui����ʾ������ȴЧ��
            sprite.fillAmount = 1;
            colding = true;
            cd=coldTime;
        }

        if (colding)
        {
            label.enabled = true;
            sprite.fillAmount -= (1f / coldTime) * Time.deltaTime;
            
            cd-=Time.deltaTime;
            label.text = cd.ToString("#0.00");
            if (sprite.fillAmount <= 0.05f)
            {
                colding = false;
                sprite.fillAmount = 0;
                cd = 0;
                label.enabled = false;
            }
                

        }
    }
}
