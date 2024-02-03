using UnityEngine;
public class GameCtx {

    public FlagRepository flagRepository;
    public int flagID;

    public TowerRepository towerRepository;
    public int towerID;

    public MstRepository mstRepository;
    public int mstID;

    public MoveRepository moveRepository;
    public int moveID;

    public PlayerEntity playerEntity;

    public InputEntity inputEntity;

    public MoveEntity moveEntity;

    public UICtx uictx;

    public AssetsCtx assetsCtx;

    public TemplateCtx tplCtx;


    public Camera mainCamera;
    //==GameCtxInit
    public GameCtx() {


        flagRepository = new FlagRepository();

        towerRepository = new TowerRepository();

        mstRepository = new MstRepository();

        moveRepository = new MoveRepository();

        playerEntity = new PlayerEntity();

        moveEntity = new MoveEntity();

        inputEntity = new InputEntity();




        flagID = 0;
        towerID = 0;
        mstID = 0;
    }

    public void Inject(Camera camera, UICtx uictx, AssetsCtx assetsCtx, TemplateCtx tplCtx) {
        this.mainCamera = camera;
        this.assetsCtx = assetsCtx;
        this.uictx = uictx;
        this.tplCtx = tplCtx;
    }

}