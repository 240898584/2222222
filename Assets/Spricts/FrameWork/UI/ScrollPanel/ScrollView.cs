using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView : ViewBase
{
    Transform contentleft;
    Transform contentright;
    GameObject Itemleft;
    GameObject Itemright;

    int kind = 1;
    public override void Init(UIWindow uIWindow)
    {
        base.Init(uIWindow);
     
        contentleft =uIWindow. transform.Find("left/Viewport/Content");
        contentright = uIWindow.transform.Find("Right/Viewport/Content1");
        Itemleft=uIWindow.transform.Find("left/Viewport/Content/Item").gameObject;
        Itemright = uIWindow.transform.Find("Right/Viewport/Content1/Item").gameObject;


    }



    internal void Refresh(Dictionary<int, List<int>> itemDic)
    {
        Itemleft.SetActive(false);
        Itemright.SetActive(false);
        for (int i = 0; i < itemDic.Count; i++)
        {
            if (contentleft.childCount > i)
            {
                contentleft.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                GameObject.Instantiate(Itemleft, contentleft).SetActive(true);
            }

        }
        for (int i = 0; i < itemDic.Count; i++)
        {
            if (contentright.childCount > i)
            {
                contentright.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                GameObject.Instantiate(Itemright, contentright).SetActive(true);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
