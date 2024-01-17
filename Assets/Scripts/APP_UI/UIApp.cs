using System;
using UnityEngine;

public static class UIApp{

    public static void PN_Login_Open(UICtx uiCtx){
        PN_Login panel = uiCtx.pn_Login;
        if(panel==null){
            panel=GameObject.Instantiate(uiCtx.assetsCtx.pn_login,uiCtx.canvas.transform);

        }

    }

}