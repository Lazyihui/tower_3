using System;
using UnityEngine;

public static class FlagDomain {

    public static FlagEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos, Color color) {

        gameCtx.assetsCtx.Entity_TryGetPrefab("FlagEntity", out GameObject prefab);
        FlagEntity entity = GameObject.Instantiate(prefab).GetComponent<FlagEntity>();
        entity.Ctor();
        entity.SetPos(pos);
        entity.SetColor(color);
        entity.id = gameCtx.flagID++;

        gameCtx.flagRepository.Add(entity);

        return entity;
    }
}