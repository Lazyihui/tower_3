public class GameCtx {
    public FlagRepository flagRepository;

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public Template tpl;

    public int flagID;

    //==GameCtxInit
    public GameCtx() {

        tpl = new Template();

        flagRepository = new FlagRepository();
        tpl.FlagTemplate_Init();
        flagID = 0;
    }

    public void Inject(UICtx uictx, AssetsCtx assetsCtx) {
        this.assetsCtx = assetsCtx;
        this.uictx = uictx;
    }

}