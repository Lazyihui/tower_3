using System;
using UnityEngine;

public static class Factory {

    public static FlagEntity Factory_Create_Flag(GameCtx gameCtx, int typeID, Vector2 pos) {

        // prefab: 模具
        FlagEntity prefab = gameCtx.assetsCtx.flagEntity;

        FlagTemplate tm = gameCtx.tpl.GetFlag(typeID);

        // instance: 实例(蛋糕)
        FlagEntity entity = GameObject.Instantiate(prefab);
        //monobehaviour -ctor ==init
        entity.Ctor();
        entity.SetColor(tm.color);
        entity.typeID = tm.typeID;
        entity.SetPos(pos);
        entity.id = gameCtx.flagID++;

        return entity;
    }

    public static TowerEntity Factory_Create_Tower(GameCtx gameCtx, int typeID, Vector2 pos) {
        TowerEntity prefab = gameCtx.assetsCtx.towerEntity;

        TowerTemplate tm = gameCtx.tpl.GetTower(typeID);

        TowerEntity entity = GameObject.Instantiate(prefab);

        entity.Ctor();
        entity.SetColor(tm.color);
        entity.typeID = typeID;
        entity.SetPos(pos);
        entity.id = gameCtx.TowerID++;
        return entity;
    }

}