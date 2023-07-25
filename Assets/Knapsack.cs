using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knapsack : MonoBehaviour
{
    public GameObject[] cells;
    public string[] equipmentsName;
    public GameObject item;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PickUp();
        }
    }
    public void PickUp()
    {
        bool isFind = false;
        int index = Random.Range(0, equipmentsName.Length);
        string name = equipmentsName[index];
        for (int i = 0; i < cells.Length; i++)
        {
            if (cells[i].transform.childCount > 0)//�жϵ�ǰ������û����Ʒ
            {//�����
                KnapsackItem item = cells[i].GetComponentInChildren<KnapsackItem>();
                if (item.sprite.spriteName == name)//�жϵ�ǰ��Ϸ�������Ƿ������Ǽ񵽵�һ��
                {
                    item.AddCount(1);
                    isFind = true;
                    break;
                }
            } 
        }
        
        if (isFind == false)//���û����������һ������Ϸ��Ʒ
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].transform.childCount == 0)//��������ǿյ�,�����������һ���µ���Ϸ��Ʒ
                {
                    GameObject go = NGUITools.AddChild(cells[i], item);
                    go.GetComponent<UISprite>().spriteName = name;
                    go.transform.localPosition = Vector3.zero;
                    break;
                }
            }
        }
       
    }
}
