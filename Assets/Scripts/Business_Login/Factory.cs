using System;
using UnityEngine;

public static class Factory {

    public static FlagEntity Factory_Create_Flag(GameCtx gameCtx, int typeID, Vector2 pos) {

        FlagEntity prefab = gameCtx.assetsCtx.flagEntity;

        FlagTemplate tm = gameCtx.tpl.GetFlag(typeID);

        FlagEntity entity = GameObject.Instantiate(prefab);
        //monobehaviour -ctor ==init
        entity.Ctor();
        entity.SetColor(tm.color);
        entity.typeID = tm.typeID;
        entity.SetPos(pos);
        entity.id = gameCtx.flagID++;

        return entity;
    }
}