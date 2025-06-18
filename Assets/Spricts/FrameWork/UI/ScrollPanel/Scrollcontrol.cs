using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControl : ControlBase
{
    //public override void Init(UIWindow uiBase)
    //{
    //    base.Init(uiBase);
    //    (uiBase.view as ScrollView).Refresh((uiBase.model as ScrollModel).itedic);
    //}
    public override void Init(UIWindow uibase)
    {
        base.Init(uibase);
        (uibase.view as ScrollView).Refresh((uibase.model as ScrollModel).itedic);
    }
}
