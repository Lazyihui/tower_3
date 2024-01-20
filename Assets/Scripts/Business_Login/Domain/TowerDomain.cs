using System;
using UnityEngine;

public static class TowerDomain {
    public static TowerEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos) {
        TowerEntity entity = Factory.Factory_Create_Tower(gameCtx, typeID, pos);

        gameCtx.towerRepository.Add(entity);
        return entity;
    }
}
