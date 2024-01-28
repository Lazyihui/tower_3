using System;
using UnityEngine;

public static class TowerDomain {
    public static TowerEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos, Color color) {

        gameCtx.assetsCtx.Entity_TryGetPrefab("TowerEntity", out GameObject prefab);

        bool has = gameCtx.tplCtx.towers.TryGetValue(typeID, out TowerTM tm);
        if (!has) {
            Debug.Log("Error");
            return null;
        }
        TowerEntity entity = GameObject.Instantiate(prefab).GetComponent<TowerEntity>();


        entity.Ctor();
        entity.SetPos(pos);
        entity.SetColor(color);
        entity.id = gameCtx.towerID++;
        entity.typeID = tm.typeID;
        entity.price = tm.price;
        entity.shapeSize = tm.shapeSize;

        entity.isSpawner = tm.isSpawner;
        entity.cd = tm.cd;
        entity.cdMax = tm.cd;
        entity.maintain = tm.maintain;
        entity.maintainTimer = tm.maintain;
        entity.interval = tm.interval;
        entity.intervalTimer = tm.interval;
        // entity.mstTypeID = tm.mstTypeID;
        entity.path = tm.path;

        // entity.SetSprite(tm.sprite);


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

            tower.intervalTimer = tower.interval;
            MstEntity mst = MstDomain.Spawn(ctx, tower.mstTypeID, tower.transform.position);
            mst.path = tower.path;
        }

        tower.maintainTimer -= fixdt;
        if (tower.maintainTimer <= 0) {
            tower.maintainTimer = tower.maintain;
            tower.cd = tower.cdMax;
        }

    }
}
