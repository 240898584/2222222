using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView:ViewBase
{
    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        var player = GameObject.Instantiate(ResourceMgr.Instance.ResLoadAsset<GameObject>("Sphere"), Boot.Instance.transform);
        player.transform.position = Vector3.up;
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
