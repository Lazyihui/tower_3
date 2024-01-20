public class GameCtx {
    public FlagRepository flagRepository;
    public int flagID;

    public TowerRepository towerRepository;
    public int towerID;

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public Template tpl;




    //==GameCtxInit
    public GameCtx() {

        tpl = new Template();

        flagRepository = new FlagRepository();

        towerRepository = new TowerRepository();

        tpl.FlagTemplate_Init();
        tpl.TowerTemplate_Init();

        flagID = 0;
        towerID=0;
    }

    public void Inject(UICtx uictx, AssetsCtx assetsCtx) {
        this.assetsCtx = assetsCtx;
        this.uictx = uictx;
    }

}