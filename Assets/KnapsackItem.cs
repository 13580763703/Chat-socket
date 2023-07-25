using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackItem : UIDragDropItem
{
    public UISprite sprite;
    public UILabel label;
    private int count = 1;

    public void AddCount(int number = 1)
    {
        count += number;
        label.text = count.ToString();
    }
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        print(surface.transform.childCount);
        
            //������Ʒ
            if (surface.tag == "Cell")
            {
                this.transform.parent = surface.transform;
                this.transform.localPosition = Vector3.zero;
        }
            else if (surface.tag == "Knapsack")
            {
                Transform parent = surface.transform.parent;
                surface.transform.parent = this.transform.parent;
                surface.transform.localPosition = Vector3.zero;

                this.transform.parent = parent;
                this.transform.localPosition = Vector3.zero;
            }
            else
            {
                this.transform.parent = surface.transform;
                this.transform.localPosition = Vector3.zero;
        }

           
        
            
        
        
    }
}
