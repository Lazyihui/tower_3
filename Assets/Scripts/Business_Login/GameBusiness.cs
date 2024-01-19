using System;
using UnityEngine;

public static class GamesBusiness {
    public static void Enter(GameCtx gameCtx) {
        Debug.Log("EnterGame");

        FlagDomain.Spawn(gameCtx, 1, new Vector2(0, -4));

    }
    // 每帧一次
    public static void PreTick(GameCtx gameCtx, float dt) {

        // for Flag

        // for Role

    }

    
}


