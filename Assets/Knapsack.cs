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
            if (cells[i].transform.childCount > 0)//判断当前格子有没有物品
            {//如果有
                KnapsackItem item = cells[i].GetComponentInChildren<KnapsackItem>();
                if (item.sprite.spriteName == name)//判断当前游戏的名字是否与我们捡到的一样
                {
                    item.AddCount(1);
                    isFind = true;
                    break;
                }
            } 
        }
        
        if (isFind == false)//如果没有遇到名字一样的游戏物品
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].transform.childCount == 0)//如果这里是空的,就在这里添加一个新的游戏物品
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
