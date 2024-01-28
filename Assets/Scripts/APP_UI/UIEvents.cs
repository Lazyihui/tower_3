using System;
using UnityEngine;

public class UIEvents {

    public Action Login_OnStartClickHandle;

    public void Login_OnClcikStart() {
        Login_OnStartClickHandle.Invoke(); 
        
    }
    public UIEvents() {

    }
}