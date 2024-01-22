using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientCtx {

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public GameCtx gameCtx;

    public TemplateCtx tplCtx;

    public ClientCtx() {
        this.uictx = new UICtx();
        this.gameCtx = new GameCtx();
        this.tplCtx = new TemplateCtx();
    }

    public void Inject(Canvas canvas, AssetsCtx assetsCtx) {
        this.assetsCtx = assetsCtx;

        uictx.Inject(canvas, assetsCtx);
        gameCtx.Inject(uictx, assetsCtx,tplCtx);
    }
}