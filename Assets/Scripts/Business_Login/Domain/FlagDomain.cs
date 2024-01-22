using System;
using UnityEngine;

public static class FlagDomain {

    public static FlagEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos, Color color) {


        FlagEntity prefab = gameCtx.assetsCtx.flagEntity;
        FlagEntity entity = GameObject.Instantiate(prefab);
        entity.Ctor();
        entity.SetPos(pos);
        entity.SetColor(color);
        entity.id = gameCtx.flagID++;
        
        gameCtx.flagRepository.Add(entity);

        return entity;
    }
}