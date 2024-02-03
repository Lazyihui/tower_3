using System;
using UnityEngine;

public static class MoveDomain {

    public static MoveEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos) {

        gameCtx.assetsCtx.Entity_TryGetPrefab("MoveEntity", out GameObject prefab);
        MoveEntity entity = GameObject.Instantiate(prefab).GetComponent<MoveEntity>();
        entity.Ctor();
        entity.SetPos(pos);
        entity.moveSpeed = 10.0f;

        gameCtx.moveRepository.Add(entity);

        return entity;
    }
}