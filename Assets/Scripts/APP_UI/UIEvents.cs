using System;
using UnityEngine;

public class UIEvents {
    //Login
    public Action Login_OnStartClickHandle;

    public void Login_OnClcikStart() {
        Login_OnStartClickHandle.Invoke();

    }

    public Action<int, int> BuildManifest_OnBuildHandle;

    public void BuildManifest_OnBuild(int clickedTowerEntityID, int clickedTowerTypeID) {
        BuildManifest_OnBuildHandle.Invoke(clickedTowerEntityID, clickedTowerTypeID);
    }
    public UIEvents() {

    }
}