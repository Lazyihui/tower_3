using System;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIApp {

    public static void PN_Login_Open(UICtx uiCtx, Action OnstartClickHandle) {
        PN_Login panel = uiCtx.pn_Login;
        if (panel == null) {
            uiCtx.assetsCtx.Panel_TryGetPrefab("Login_Panel", out GameObject prefab);
            panel = GameObject.Instantiate(prefab, uiCtx.canvas.transform).GetComponent<PN_Login>();
            panel.Ctor();
            uiCtx.pn_Login = panel;
            panel.OnstartClickHandle = OnstartClickHandle;
        }
        panel.Show();

    }

    public static void PN_Login_Close(UICtx uictx) {
        PN_Login panel = uictx.pn_Login;
        if (panel != null) {
            panel.Close();
        }
    }
    public static void PN_HeartInfo_Open(){}

}