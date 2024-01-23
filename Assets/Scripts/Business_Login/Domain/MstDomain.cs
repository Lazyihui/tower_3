using UnityEngine;

public static class MstDomain {
    public static MstEntity Spawn(GameCtx gameCtx, int typeID, Vector2 pos) {

        bool has = gameCtx.tplCtx.msts.TryGetValue(typeID, out MstTM mstTM);
        if (!has) {
            Debug.LogError("on find" + typeID);
        }
        gameCtx.assetsCtx.Entity_TryGetPrefab("MstEntity", out GameObject prefab);
        MstEntity entity = GameObject.Instantiate(prefab).GetComponent<MstEntity>();
        entity.Ctor();
        entity.SetPos(pos);
        entity.id = gameCtx.mstID++;
        entity.moveSpeed = mstTM.moveSpeed;
        gameCtx.mstRepository.Add(entity);
        Debug.Log("生成的mst" + typeID);
        return entity;
    }

    public static void UnSpawn(GameCtx gameCtx, MstEntity mst) {
        gameCtx.mstRepository.Remove(mst);
        mst.TearDown();
    }

    public static void MoveByPath(GameCtx gameCtx, MstEntity mst, float fixdt) {
        if (mst.path == null) {
            return;

        }
        if (mst.pathIndex >= mst.path.Length) {
            return;
        }

        Vector2 target = mst.path[mst.pathIndex];

        Vector2 dir = target - (Vector2)mst.transform.position;

        if (dir.sqrMagnitude <= 0.01f) {
            mst.pathIndex += 1;
        } else {
            dir.Normalize();
            mst.Move(dir, fixdt);
        }

    }

    public static void OverlapFlag(GameCtx ctx, MstEntity mst) {
        // 找到所有Flag, 并且与Role碰撞
        FlagEntity target = ctx.flagRepository.Find((FlagEntity flag) => {
            float disSqr = Vector2.SqrMagnitude((Vector2)mst.transform.position - (Vector2)flag.transform.position);
            if (disSqr < 0.1f) {
                return true;
            } else {
                return false;
            }
        });

        if (target != null) {
            UnSpawn(ctx, mst);
            // PlayerDomain.Hurt(ctx, ctx.playerEntity, 1);
        }
    }

}