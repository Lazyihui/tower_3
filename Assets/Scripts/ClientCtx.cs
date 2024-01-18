using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientCtx {

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public GameCtx gameCtx;

    public ClientCtx() {
        this.uictx = new UICtx();
        this.gameCtx=new GameCtx();
    }

    public void Inject(Canvas canvas, AssetsCtx assetsCtx) {
        this.assetsCtx = assetsCtx;

        uictx.Inject(canvas, assetsCtx);
        gameCtx.Inject(uictx,assetsCtx);
    }   
}