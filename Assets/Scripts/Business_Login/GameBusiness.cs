using System;
using UnityEngine;

public static class GamesBusiness {
    public static void Enter(GameCtx gameCtx) {

        gameCtx.playerEntity.hp = 5;
        gameCtx.playerEntity.hpMax = 5;

        FlagDomain.Spawn(gameCtx, 1, new Vector2(0, -4), Color.yellow);
        //刷怪点
        TowerDomain.Spawn(gameCtx, 1000, new Vector2(0, 4));

        // 空地
        TowerDomain.Spawn(gameCtx, 100, new Vector2(-1, 0));

        //move

        MoveDomain.Spawn(gameCtx, 1, new Vector2(0, 0));
        

        //打开UI
        UIApp.PN_HeartInfo_Open(gameCtx.uictx, gameCtx.playerEntity.hp);

    }



    // 可能一帧有多次
    public static void FixedTick(GameCtx gameCtx, float fixdt) {
        // for Tower
        int towerLen = gameCtx.towerRepository.TakeAll(out TowerEntity[] towers);
        for (int i = 0; i < towerLen; i += 1) {
            TowerEntity tower = towers[i];

            TowerDomain.TrySpawnMsts(gameCtx, tower, fixdt);
        }
        // for mst
        int mstLen = gameCtx.mstRepository.TakeAll(out MstEntity[] msts);
        for (int i = 0; i < mstLen; i++) {
            MstEntity mst = msts[i];
            MstDomain.MoveByPath(gameCtx, mst, fixdt);
            MstDomain.OverlapFlag(gameCtx, mst);
        }

    }

    // 每帧一次
    public static void PreTick(GameCtx gameCtx, float dt) {

        InputEntity input = gameCtx.inputEntity;
        //屏幕空间
        input.mouseScreenPos = Input.mousePosition;
        //世界
        Camera camera = gameCtx.mainCamera;
        //ScreenToViewportPoint 屏幕转世界
        input.mouseWorldPos = camera.ScreenToWorldPoint(input.mouseScreenPos);
        if (Input.GetMouseButtonDown(0)) {
            input.isMouseLeftDown = true;
            //tower

        }
        UserInterfaceDomain.PreTick(gameCtx, dt);
        // for Flag

        // for Role

    }


    public static void LateTick(GameCtx ctx, float dt) {
        UIApp.PN_HearInfo_Update(ctx.uictx, ctx.playerEntity.hp);
        ctx.inputEntity.Reset();
    }

    //事假反馈
    public static void BuildManifest_OnBuild(GameCtx ctx, int clickedTowerEntityID, int clickedTowerTypeID) {
        // clickedTowerEntityID 表示: 基于谁, 造在哪里
        // clickedTowerTypeID 表示造什么
        bool has = ctx.towerRepository.TryGet(clickedTowerEntityID, out TowerEntity clickedTowerEntity);
        if (!has) {
            Debug.Log("err");
            return;
        }
        //clcikedPos 新生成tower的Pos
        Vector2 clickedPos = clickedTowerEntity.transform.position;
        //销毁原来的Tower生成新的tower
        TowerDomain.Unspawn(ctx, clickedTowerEntity);

        TowerDomain.Spawn(ctx, clickedTowerTypeID, clickedPos);

        Debug.Log("towerID" + clickedTowerEntityID);


        UIApp.PN_BulidManifast_Close(ctx.uictx);

    }
}



