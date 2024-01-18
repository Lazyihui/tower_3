using System;
using UnityEngine;

public static class FlagDomain {

    public static FlagEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos) {

        // prefab: 模具
        // instance: 实例(蛋糕)
        FlagEntity prefab = gameCtx.assetsCtx.flagEntity;

        FlagEntity entity = GameObject.Instantiate(prefab);

        
        return entity;
    }
}