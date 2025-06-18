using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollModel : ModelBase
{

    public Dictionary<int,List<int>>itedic=new Dictionary<int,List<int>>();
    public override void Init(UIWindow uibase)
    {
        base.Init(uibase);
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                if (!itedic.ContainsKey(i)){
                    itedic.Add(i, new List<int>());
                }
                itedic[i].Add(j);
            }
        }
    }
   
    //public Dictionary<int,List<int>>itemdic=new Dictionary<int,List<int>>();
    //public override void Init(UIWindow uiBase)
    //{
    //    base.Init(uiBase);
    //    for(int i = 1; i <=10; i++)
    //    {
    //        for(int j = 1; j <=10; j++)
    //        {
    //            if (!itemdic.ContainsKey(i))
    //            {
    //                itemdic.Add(i, new List<int>());
    //            }
    //            itemdic[i].Add(j);
    //        }
    //    }
    //}
}
