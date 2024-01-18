using System;
using UnityEngine;

public class Factory {

    public FlagEntity Factory_Create_Flag(GameCtx gameCtx, int typeID, Vector2 pos) {
        
        FlagTemplate tm = gameCtx.tpl.GetFlag(typeID);

        FlagEntity entity = new FlagEntity();

        

        return ;
    }
}