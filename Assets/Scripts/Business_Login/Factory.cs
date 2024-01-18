using System;
using UnityEngine;

public  class Factory {

    public FlagEntity Factory_Create_Flag(GameCtx gameCtx, int typeID) {
        
        FlagTemplate tm = gameCtx.tpl.GetFlag(typeID);

        FlagEntity entity = new FlagEntity();

        entity.color = tm.color;
        entity.typeID = tm.typeID;

        return entity;
    }
}