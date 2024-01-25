public class GameCtx {
    public FlagRepository flagRepository;
    public int flagID;

    public TowerRepository towerRepository;
    public int towerID;

    public MstRepository mstRepository;
    public int mstID;

    public PlayerEntity playerEntity;

    public InputEntity inputEntity;

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public TemplateCtx tplCtx;



    //==GameCtxInit
    public GameCtx() {


        flagRepository = new FlagRepository();

        towerRepository = new TowerRepository();

        mstRepository = new MstRepository();

        playerEntity = new PlayerEntity();

        inputEntity = new InputEntity();




        flagID = 0;
        towerID = 0;
        mstID = 0;
    }

    public void Inject(UICtx uictx, AssetsCtx assetsCtx, TemplateCtx tplCtx) {
        this.assetsCtx = assetsCtx;
        this.uictx = uictx;
        this.tplCtx = tplCtx;
    }

}