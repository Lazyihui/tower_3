using System;
using UnityEngine;

public static class FlagDomain {

    public static FlagEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos) {

      
        FlagEntity entity = Factory.Factory_Create_Flag(gameCtx, typeID,pos);

        gameCtx.flagRepository.Add(entity);

        return entity;
    }
}