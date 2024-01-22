using System;
using UnityEngine;

public static class GamesBusiness {
    public static void Enter(GameCtx gameCtx) {

        FlagDomain.Spawn(gameCtx, 1, new Vector2(0, -4), Color.yellow);

        TowerDomain.Spawn(gameCtx, 1, new Vector2(0, 4), Color.blue);
    }

    // 可能一帧有多次
    public static void FixedTick(GameCtx ctx, float fixdt) {
        // for Tower
        int towerLen = ctx.towerRepository.TakeAll(out TowerEntity[] towers);
        for (int i = 0; i < towerLen; i += 1) {
            Debug.Log("hhh");

            TowerEntity tower = towers[i];
            TowerDomain.TrySpawnMsts(ctx, tower, fixdt);
        }
        // for mst
        int mstLen = ctx.mstRepository.TakeAll(out MstEntity[] msts);
        for (int i = 0; i < mstLen; i++) {
            MstEntity mst = msts[i];
            MstDomain.MoveByPath(ctx, mst, fixdt);
            MstDomain.OverlapFlag(ctx, mst);
        }

    }

    // 每帧一次
    public static void PreTick(GameCtx gameCtx, float dt) {

        // for Flag

        // for Role

    }


}


