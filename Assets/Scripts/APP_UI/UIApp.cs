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
    public static void PN_HeartInfo_Open(UICtx uiCtx, int hp) {
        PN_HeartInfo heart = uiCtx.pn_Heart;
        if (heart == null) {
            uiCtx.assetsCtx.Panel_TryGetPrefab("Panel_HeartInfo", out GameObject prefab);
            heart = GameObject.Instantiate(prefab, uiCtx.canvas.transform).GetComponent<PN_HeartInfo>();
            heart.Ctor();
            uiCtx.pn_Heart = heart;

        }
        heart.Init(hp);
        heart.Show();
    }
    public static void PN_HearInfo_Update(UICtx ctx, int hp) {
        PN_HeartInfo heart = ctx.pn_Heart;
        if (heart != null) {
            heart.Init(hp);
        }
    }
    public static void PN_HearInfo_Close(UICtx ctx) {
        PN_HeartInfo heart = ctx.pn_Heart;
        if (heart != null) {
            heart.Close();
        }
    }

}