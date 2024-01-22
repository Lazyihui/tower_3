using System;
using UnityEngine;

public static class TowerDomain {
    public static TowerEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos, Color color) {
        TowerEntity prefab = gameCtx.assetsCtx.towerEntity;

        TowerEntity entity = GameObject.Instantiate(prefab);

        entity.Ctor();
        entity.SetPos(pos);
        entity.SetColor(color);
        entity.id = gameCtx.towerID++;
        entity.InitFakeData();


        gameCtx.towerRepository.Add(entity);
        return entity;
    }
    public static void TrySpawnMsts(GameCtx ctx, TowerEntity tower, float fixdt) {
        // 单个塔生成怪物
        if (!tower.isSpawner) {
            return;
        }

        tower.cd -= fixdt; // 0.2 0.3
        if (tower.cd > 0) {
            return;
        }
        //生成时间
        tower.intervalTimer -= fixdt;

        if (tower.intervalTimer <= 0) {
            Debug.Log("Spawn");

            tower.intervalTimer = tower.interval;
            MstEntity mst = MstDomain.Spawn(ctx, tower.MstTypeID, tower.transform.position);
            mst.path = tower.path;
        }

        tower.maintainTimer -= fixdt;
        if (tower.maintainTimer <= 0) {
            tower.maintainTimer = tower.maintain;
            tower.cd = tower.cdMax;
        }

    }
}
