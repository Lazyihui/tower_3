using System;
using UnityEngine;

public static class GamesBussiness {
    public static void Enter(GameCtx gameCtx) {
        Debug.Log("EnterGame");

        FlagDomain.Spawn(gameCtx, 1, new Vector2(0, -5));

    }
    // 每帧一次
    public static void PreTick(GameCtx gameCtx, float dt) {

        // for Flag

        // for Role

    }

    
}


