public class GameCtx {
    public FlagRepository flagRepository;
    public int flagID;

    public TowerRepository towerRepository;
    public int towerID;

    public MstRepository mstRepository;
    public int mstID;

    public UICtx uictx;

    public AssetsCtx assetsCtx;





    //==GameCtxInit
    public GameCtx() {


        flagRepository = new FlagRepository();

        towerRepository = new TowerRepository();

        mstRepository = new MstRepository();



        flagID = 0;
        towerID = 0;
        mstID = 0;
    }

    public void Inject(UICtx uictx, AssetsCtx assetsCtx) {
        this.assetsCtx = assetsCtx;
        this.uictx = uictx;
    }

}