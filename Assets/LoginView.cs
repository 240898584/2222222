using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : ViewBase
{
    public Button loginbutton;

    public override void Init(UIWindow uIWindow)
    {
        base.Init(uIWindow);
        loginbutton = uIWindow. transform.Find("Button").GetComponent<Button>();
        loginbutton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnLoginButtonClick()
    {
        GameScenesManager.Instance.LoadSceneAsync("Game", "PlayerPanel");
    }


}
