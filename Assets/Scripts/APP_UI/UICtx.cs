using UnityEngine;

public class UICtx {
    public PN_Login pn_Login;

    public PN_HeartInfo pn_Heart;

    public Canvas screenCanvas;

    public Canvas worldCanvas;

    public AssetsCtx assetsCtx;


    public PN_BuildManifest pn_BuildManifest;

    public UICtx() {

    }

    public void Inject(Canvas screenCanvas, AssetsCtx assetsCtx, Canvas worldCanvas) {
        this.screenCanvas = screenCanvas;
        this.worldCanvas = worldCanvas;
        this.assetsCtx = assetsCtx;

    }


}