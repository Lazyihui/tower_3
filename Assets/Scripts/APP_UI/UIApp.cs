using System;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIApp {

    public static void PN_Login_Open(UICtx uiCtx, Action OnstartClickHandle) {
        PN_Login panel = uiCtx.pn_Login;
        if (panel == null) {
            panel = GameObject.Instantiate(uiCtx.assetsCtx.pn_login, uiCtx.canvas.transform);
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

}