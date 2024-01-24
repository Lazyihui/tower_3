using UnityEngine;

public class UICtx {
    public PN_Login pn_Login;

    public PN_HeartInfo pn_Heart;

    public Canvas canvas;

    public AssetsCtx assetsCtx;

    public UICtx() {

    }

    public void Inject(Canvas canvas, AssetsCtx assetsCtx) {
        this.canvas = canvas;
        this.assetsCtx = assetsCtx;
    }


}