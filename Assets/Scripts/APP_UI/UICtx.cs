using UnityEngine;

public class UICtx {
    public PN_Login pn_Login;

    public PN_HeartInfo pn_Heart;

    public Canvas screenCanvas;

    public Canvas worldCanvas;

    public AssetsCtx assetsCtx;

    public TemplateCtx templateCtx;


    public PN_BuildManifest pn_BuildManifest;

    public UIEvents events;

    public UICtx() {

        events = new UIEvents();

    }

    public void Inject(Canvas screenCanvas, AssetsCtx assetsCtx, Canvas worldCanvas, TemplateCtx templateCtx) {
        this.screenCanvas = screenCanvas;
        this.worldCanvas = worldCanvas;
        this.assetsCtx = assetsCtx;
        this.templateCtx = templateCtx;

    }


}