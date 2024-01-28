using System;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIApp {

    public static void PN_Login_Open(UICtx uiCtx) {
        PN_Login panel = uiCtx.pn_Login;
        if (panel == null) {
            uiCtx.assetsCtx.Panel_TryGetPrefab("Login_Panel", out GameObject prefab);
            panel = GameObject.Instantiate(prefab, uiCtx.screenCanvas.transform).GetComponent<PN_Login>();
            panel.Ctor();
            uiCtx.pn_Login = panel;
            panel.OnstartClickHandle = () => {
                uiCtx.events.Login_OnClcikStart();
            };
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
            heart = GameObject.Instantiate(prefab, uiCtx.screenCanvas.transform).GetComponent<PN_HeartInfo>();
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

    //PN_BuildManifest
    //面板打开（基本上都是这么写）
    public static void PN_BuildManifest_Open(UICtx uiCtx, Vector3 worldPos) {
        PN_BuildManifest panel = uiCtx.pn_BuildManifest;
        if (panel == null) {
            uiCtx.assetsCtx.Panel_TryGetPrefab("Panel_BulidManifast", out GameObject prefab);
            panel = GameObject.Instantiate(prefab, uiCtx.worldCanvas.transform).GetComponent<PN_BuildManifest>();
            panel.Ctor();
            uiCtx.pn_BuildManifest = panel;

            panel.OnBuildHandle = (int clickedTowerEntityID, int clickedTowerTypeID) => {
                uiCtx.events.BuildManifest_OnBuild(clickedTowerEntityID, clickedTowerTypeID);
            };

        }
        panel.Init(worldPos);
    }

    public static void PN_BuildManifest_AddOption(UICtx uictx, int clickedTowerEntityID, int clickedTowerTypeID) {
        PN_BuildManifest panel = uictx.pn_BuildManifest;
        if (panel != null) {
            panel.AddOption(clickedTowerEntityID, clickedTowerTypeID, 10, null);
        }
    }

    public static void Panel_BulidManifast_Close(UICtx uiCtx) {
        PN_BuildManifest panel = uiCtx.pn_BuildManifest;
        if (panel != null) {
            panel.TearDown();
            uiCtx.pn_BuildManifest = null;
        }
    }

}